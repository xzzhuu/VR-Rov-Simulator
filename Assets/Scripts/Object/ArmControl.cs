using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControl : MonoBehaviour
{

    public GameObject armNote1;
    public GameObject armNode2;
    public GameObject armNode3;
    public GameObject armNodeRote;
    public GameObject armFinger1;
    public GameObject armFinger2;
    void Start()
    {
      
        armNote1 = transform.Find("robotic_arm/ArmJoint0").gameObject;
        armNode2 = armNote1.transform.Find("robotic_arm_0/ArmJoint1").gameObject;
        armNode3 = armNode2.transform.Find("robotic_arm2/ArmJoint3").gameObject;
        armNodeRote = armNode3.transform.Find("robotic_arm3/ArmJoint4").gameObject;
        armFinger1 = armNodeRote.transform.Find("robotic_arm4/robotic_arm5/ArmJoint5").gameObject;
        armFinger2 = armNodeRote.transform.Find("robotic_arm4/robotic_arm5/ArmJoint5_1").gameObject;
        
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
}
