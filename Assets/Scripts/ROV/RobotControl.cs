using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RobotControl : MonoSingleton<RobotControl>
{
    public GameObject ROV;
    public GameObject armNote1;
    public GameObject armNode2;
    public GameObject armNode3;
    public GameObject armNodeRote;
    public GameObject armFinger1;
    public GameObject armFinger2;

    //垂直转动的螺旋桨Transform数组集合
    public List<Transform> V_Propellers = new List<Transform>(3);
    //水平转动的螺旋桨Transform数组集合
    public List<Transform> H_Propellers = new List<Transform>(4);
    float mPropSpeed = 500;

    public GameObject PT_RoteteH;
    public GameObject PT_RoteteV;
    public GameObject PT_BottomRoteteH;
    public GameObject PT_BottomRotateV;

    public GameObject flotPan;
    void Start()
    {
        InitROV();
    }
    public override void Awake()
    {
        //base.Awake();
    }
    /// <summary>
    /// 初始化 对象引用查找
    /// </summary>
    void InitROV()
    {
        ROV = this.gameObject.transform.Find(PathData.ROV).gameObject;

        armNote1 = ROV.transform.Find(PathData.ARM_NOTE1).gameObject;
        armNode2 = armNote1.transform.Find(PathData.ARM_NOTE2).gameObject;
        armNode3 = armNode2.transform.Find(PathData.ARM_NOTE3).gameObject;
        armNodeRote = armNode3.transform.Find(PathData.ARM_NOTEROTE).gameObject;
        armFinger1 = armNodeRote.transform.Find(PathData.ARM_FINGER1).gameObject;
        armFinger2 = armNodeRote.transform.Find(PathData.ARM_FINGER2).gameObject;

        PT_RoteteH = ROV.transform.Find(PathData.PT_ROTATE_H).gameObject;
        PT_RoteteV = PT_RoteteH.transform.Find(PathData.PT_ROTATE_V).gameObject;
        PT_BottomRoteteH = ROV.transform.Find(PathData.PT_BOTTOM_ROTATE_H).gameObject;
        PT_BottomRotateV = PT_BottomRoteteH.transform.Find(PathData.PT_BOTTOM_ROTATE_V).gameObject;

        V_Propellers.Add(ROV.transform.Find(PathData.V_PROPELLLER1).transform);
        V_Propellers.Add(ROV.transform.Find(PathData.V_PROPELLLER2).transform);
        V_Propellers.Add(ROV.transform.Find(PathData.V_PROPELLLER3).transform);
        H_Propellers.Add(ROV.transform.Find(PathData.H_PROPELLER1).transform);
        H_Propellers.Add(ROV.transform.Find(PathData.H_PROPELLER2).transform);
        H_Propellers.Add(ROV.transform.Find(PathData.H_PROPELLER3).transform);
        H_Propellers.Add(ROV.transform.Find(PathData.H_PROPELLER4).transform);

        flotPan = ROV.transform.Find(PathData.FLOTPAN).gameObject;
    }
    /// <summary>
    /// ROV水平面移动 Foward/Back/Left/Right
    /// </summary>
    /// <param name="direct">方向枚举值</param>
    public void MoveROVInHorizontal(DIR dir, float speed = 1)
    {
        switch (dir)
        {
            case DIR.Foward:
                ROV.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_FWD, new MessageData((int)DIR.Foward));
                break;
            case DIR.Back:
                ROV.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_BWD, new MessageData((int)DIR.Back));
                break;
            case DIR.Left:
                ROV.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_LEFT, new MessageData((int)DIR.Left));
                break;
            case DIR.Right:
                ROV.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_RIGHT, new MessageData((int)DIR.Right));
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// ROV垂直面移动 Up/Down
    /// </summary>
    /// <param name="direct">方向枚举值</param>
    public void MoveROVInVertical(DIR dir, float speed = 1)
    {
        switch (dir)
        {
            case DIR.Up:
               // if (!isVerticalMoveArea(ROV.transform.localPosition.y)) return;
                ROV.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Vertical);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_UP, new MessageData((int)DIR.Up));
                break;
            case DIR.Down:
              //  if (!isVerticalMoveArea(ROV.transform.localPosition.y)) return;
                ROV.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Vertical);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_DOWN, new MessageData((int)DIR.Down));
                break;
            default:
                break;
        }
    }

    
    bool isVerticalMoveArea(float value)
    {
        if (value > 0f && value < 6.5f) return true;
        return false;
    }
    /// <summary>
    /// ROV旋转 TurnL/TurnR
    /// </summary>
    /// <param name="direct">方向枚举值</param>
    public void RotateROV(DIR dir, float speed = 1)
    {
        switch (dir)
        {
            case DIR.TurnL:
                ROV.transform.Rotate(new Vector3(0, -speed * 5 * Time.deltaTime, 0));
                ThrusterControl(-mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_TURN_L, new MessageData((int)DIR.TurnL));
                break;
            case DIR.TurnR:
                ROV.transform.Rotate(new Vector3(0, speed * 5 * Time.deltaTime, 0));
                ThrusterControl(mPropSpeed, PROPDIR.Horizontal);
                MsgMng.Instance.Send(MessageName.MSG_MOVE_TURN_R, new MessageData((int)DIR.TurnR));
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 云台摄像机移动 Foward/Back/Left/Right
    /// </summary>
    /// <param name="direct"></param>
    public void PanTiltCamRotate(DIR dir, float speed = 1)
    {
        GameObject ptH = ControlData.Instance.curPT == 1 ? PT_RoteteH : PT_BottomRoteteH;
        GameObject ptV = ControlData.Instance.curPT == 1 ? PT_RoteteV : PT_BottomRotateV;
        switch (dir)
        {
            case DIR.Foward:
                ptV.transform.Rotate(new Vector3(5 * Time.deltaTime * speed, 0, 0));
                break;
            case DIR.Back:
                ptV.transform.Rotate(new Vector3(-5 * Time.deltaTime * speed, 0, 0));
                break;
            case DIR.Left:
                ptH.transform.Rotate(new Vector3(0, -5 * Time.deltaTime * speed, 0));
                break;
            case DIR.Right:
                ptH.transform.Rotate(new Vector3(0, 5 * Time.deltaTime * speed, 0));
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 推进器（螺旋桨）运动 Horizontal/Vertical/Both
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="pd"></param>
    private void ThrusterControl(float speed, PROPDIR pd)
    {
        switch (pd)
        {
            case PROPDIR.Horizontal:
                for (int i = 0; i < H_Propellers.Count; i++)
                {
                    H_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
                }
                break;
            case PROPDIR.Vertical:
                for (int i = 0; i < V_Propellers.Count; i++)
                {
                    V_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
                }
                break;
            case PROPDIR.Both:
                for (int i = 0; i < H_Propellers.Count; i++)
                {
                    H_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
                }
                for (int i = 0; i < V_Propellers.Count; i++)
                {
                    V_Propellers[i].transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
                }
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 机械臂移动 Left/Right/Up/Down
    /// </summary>
    /// <param name="armDir"></param>
    public void MoveArm(ARMDIR armDir, float speed = 1)
    {
        switch (armDir)
        {
            case ARMDIR.Left:
                armNote1.transform.Rotate(new Vector3(0, -10 * Time.deltaTime * speed, 0));
                break;
            case ARMDIR.Right:
                armNote1.transform.Rotate(new Vector3(0, 10 * Time.deltaTime * speed, 0));
                break;
            case ARMDIR.Up:
                armNode2.transform.Rotate(new Vector3(0, 0, 10 * Time.deltaTime * speed));
                break;
            case ARMDIR.Down:
                armNode2.transform.Rotate(new Vector3(0, 0, -10 * Time.deltaTime * speed));
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 机械臂伸缩 Long/Short
    /// </summary>
    /// <param name="armDir">伸缩方向</param>
    public void StretchArm(ARMDIR armDir, float speed = 1)
    {
        switch (armDir)
        {
            case ARMDIR.Long:
                if (armNode3.transform.localPosition.y < 0.65f)
                {
                    armNode3.transform.Translate(0, 0.05f * Time.deltaTime * speed, 0);
                }
                break;
            case ARMDIR.Short:
                if (armNode3.transform.localPosition.y > 0.4f)
                {
                    armNode3.transform.Translate(0, -0.05f * Time.deltaTime * speed, 0);
                }
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 机械爪开合 In/Out localEulerAngles.x==(0-90)
    /// </summary>
    /// <param name="armDir"></param>
    public void OpenCloseGripper(ARMDIR armDir, float speed = 1)
    {
        switch (armDir)
        {
            case ARMDIR.In:
                if (armFinger1.transform.localEulerAngles.x >= 0f)
                {
                    armFinger1.transform.Rotate(new Vector3(-10f * Time.deltaTime * speed, 0, 0));
                    armFinger2.transform.Rotate(new Vector3(-10f * Time.deltaTime * speed, 0, 0));
                }
                else
                {
                    armFinger1.transform.localEulerAngles = new Vector3(0f, 180f, 0f);
                    armFinger2.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
                    Debug.Log("机械爪已达到最小的开度0了");
                }
                break;
            case ARMDIR.Out:
                if (armFinger1.transform.localEulerAngles.x <= 90f)
                {
                    armFinger1.transform.Rotate(new Vector3(10f * Time.deltaTime * speed, 0, 0));
                    armFinger2.transform.Rotate(new Vector3(10f * Time.deltaTime * speed, 0, 0));
                }
                else
                {
                    armFinger1.transform.localEulerAngles = new Vector3(90f, 180f, 0f);
                    armFinger2.transform.localEulerAngles = new Vector3(90f, 0f, 0f);
                    Debug.Log("机械爪已达到最大的开度90了");
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 机械爪旋转 TurnL/TurnR
    /// </summary>
    /// <param name="armDir"></param>
    public void RotateGripper(ARMDIR armDir, float speed = 1)
    {
        switch (armDir)
        {
            case ARMDIR.TurnL:
                armNodeRote.transform.Rotate(new Vector3(0, 10 * Time.deltaTime * speed, 0));
                break;
            case ARMDIR.TurnR:
                armNodeRote.transform.Rotate(new Vector3(0, -10 * Time.deltaTime * speed, 0));
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 托盘移动
    /// </summary>
    /// <param name="isIn"></param>
    public void FlotControl(bool isIn)
    {
        float speed = isIn ? -1 : 1;
        flotPan.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        if (!isIn)
        {
            if (flotPan.transform.localPosition.z > 1f)
            {
                flotPan.transform.localPosition = new Vector3(flotPan.transform.localPosition.x, flotPan.transform.localPosition.y, 1f);
            }
        }
        else
        {
            if (flotPan.transform.localPosition.z < 0f)
            {
                flotPan.transform.localPosition = new Vector3(flotPan.transform.localPosition.x, flotPan.transform.localPosition.y, 0f);
            }
        }
    }

  
   
}

/// <summary>
/// ROV 运动姿态方向枚举值
/// </summary>
public enum DIR
{
    Foward = 1,
    Back = 2,
    Left = 3,
    Right = 4,
    Up = 5,
    Down = 6,
    TurnL = 7,
    TurnR = 8
}

//螺旋桨运行姿态方向枚举值
public enum PROPDIR
{
    Horizontal = 1,
    Vertical = 2,
    Both = 3

}
public enum ARMDIR
{
    Left = 1,//左右移动机械臂
    Right = 2,
    Up = 3,//上下移动机械臂
    Down = 4,
    Long = 5,//伸长机械臂
    Short = 6,//收缩机械臂
    In = 7,//减少机械爪的开度
    Out = 8,//增加机械爪的开度
    TurnL = 9,//左旋转机械爪
    TurnR = 10,//右旋转机械爪
}

