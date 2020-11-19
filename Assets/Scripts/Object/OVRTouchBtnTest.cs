using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OVRTouchBtnTest : MonoBehaviour
{
    
    Text txt_LTouchBtnState;
    Text txt_RTouchBtnState;
    Text txt_LTouchValue;
    Text txt_RTouchValue;

    string rThumbstickDirStr;
    int rCount=0;

    string lThumbstickDirStr;
    int lCount = 0;


    void Start()
    {
        txt_LTouchBtnState = transform.Find("Txt_LTouchBtnState").GetComponent<Text>();
        txt_RTouchBtnState = transform.Find("Txt_RTouchBtnState").GetComponent<Text>();
        txt_LTouchValue = transform.Find("Txt_LTouchValue").GetComponent<Text>();
        txt_RTouchValue = transform.Find("Txt_RTouchValue").GetComponent<Text>();

        txt_LTouchBtnState.text = "按键状态：";
        txt_RTouchBtnState.text = "按键状态：";
        txt_LTouchValue.text = string.Empty;
        txt_RTouchValue.text = string.Empty;
        // StartCoroutine(ClearTxt(txt_LTouchBtnState));
        //StartCoroutine(ClearTxt(txt_RTouchBtnState));
      
    }
    void OnClickDown() { }
    void Update()
    {
        //Get() 按住多次触发事件 
        //GetDown()、GetUp()按下和抬起的时候各只触发一次
        RightTouchState();//右手Touch控制器按键事件
        LeftTouchState();//左手Touch控制器按键事件


    }

    /*----------右手Touch控制器按键事件--------------*/
    void RightTouchState()
    {

        /*右手控制器RThumbstick按键事件（第一种方式对摇杆按键操作）*/
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {
            txt_RTouchBtnState.text = "按键状态：摇杆上按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown))
        {
            txt_RTouchBtnState.text = "按键状态：摇杆下按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
        {

            txt_RTouchBtnState.text = "按键状态：摇杆左按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
        {
            txt_RTouchBtnState.text = "按键状态：摇杆右按下";
        }

        /*右手控制器RIndexTrigger扳机键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            txt_RTouchBtnState.text = "按键状态：扳机键按下";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {

            txt_RTouchBtnState.text = "按键状态：扳机键松开";
            rCount = 0;
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            rCount++;
            txt_RTouchBtnState.text = "按键状态：按住扳机键" + "-<" + rCount.ToString();
        }

        /*右手控制器RHandTrigger侧卧键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))

        {
            txt_RTouchBtnState.text = "按键状态：侧握键按下";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.RHandTrigger))

        {
            rCount = 0;
            txt_RTouchBtnState.text = "按键状态：侧握键松开";
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {
            rCount++;
            txt_RTouchBtnState.text = "按键状态：按住侧握键" + "-<" + rCount.ToString();
        }

        /*右手控制器A键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            txt_RTouchBtnState.text = "按键状态：按键A(右)按下";
        }
        ////按住
        if (OVRInput.Get(OVRInput.RawButton.A))
        {
            txt_RTouchBtnState.text = "按键状态：按键A(右)按住";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.A))
        {
            txt_RTouchBtnState.text = "按键状态：按键A(右)松开";
        }

        /*右手控制器B键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            txt_RTouchBtnState.text = "按键状态：按键B(右)按下";
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            txt_RTouchBtnState.text = "按键状态：按键B(右)按住";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.B))
        {
            txt_RTouchBtnState.text = "按键状态：按键B(右)松开";
        }
    }


    /*----------左手Touch控制器按键事件--------------*/
    void LeftTouchState()
    {
        /*左手控制器LThumbstick按键事件（第一种方式对摇杆按键操作）*/
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp))
        {
            txt_LTouchBtnState.text = "按键状态：摇杆上按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown))
        {
            txt_LTouchBtnState.text = "按键状态：摇杆下按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft))
        {

            txt_LTouchBtnState.text = "按键状态：摇杆左按下";
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight))
        {
            txt_LTouchBtnState.text = "按键状态：摇杆右按下";
        }

        /*右手控制器RIndexTrigger扳机键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            txt_LTouchBtnState.text = "按键状态：扳机键按下";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger))
        {

            txt_LTouchBtnState.text = "按键状态：扳机键松开";
            lCount = 0;
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            lCount++;
            txt_LTouchBtnState.text = "按键状态：按住扳机键" + "-<" + lCount.ToString();
        }

        /*左手控制器LHandTrigger侧卧键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger))

        {
            txt_LTouchBtnState.text = "按键状态：侧握键按下";
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            txt_LTouchBtnState.text = "按键状态：侧握键按住";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.LHandTrigger))

        {
            txt_LTouchBtnState.text = "按键状态：侧握键松开";
        }

        /*左手控制器A键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            txt_LTouchBtnState.text = "按键状态：按键X(左)按下";
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            txt_LTouchBtnState.text = "按键状态：按键X(左)按住";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            txt_LTouchBtnState.text = "按键状态：按键X(左)松开";
        }

        /*左手控制器B键按键事件*/
        //按下
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            txt_LTouchBtnState.text = "按键状态：按键Y(左)按下";
        }
        //按住
        if (OVRInput.Get(OVRInput.RawButton.Y))
        {
            txt_LTouchBtnState.text = "按键状态：按键Y(左)按住";
        }
        //抬起
        if (OVRInput.GetUp(OVRInput.RawButton.Y))
        {
            txt_LTouchBtnState.text = "按键状态：按键Y(左)松开";
        }

    }

    //手柄控制器的摇杆全方位滑动控制（第二种方式对摇杆按键操作）
    void ThumbstickSlide(OVRInput.RawAxis2D Thumbstick, string ThumbstickDirStr, Text txt_TouchBtnState)
    {
        //获取手柄Thumbstick按键Vector2的值（方向）
        Vector2 vector2 = OVRInput.Get(Thumbstick);
        float angle = VectorAngle(new Vector2(1, 0), vector2);

        //下方向 
        if (angle > 45 && angle < 135)
        {
            ThumbstickDirStr = "{下方向：" + vector2 + "}";
        }
        //上方向
        else if (angle < -45 && angle > -135)
        {
            ThumbstickDirStr = "{上方向：" + vector2 + "}";
        }
        //左方向    
        else if ((angle < 180 && angle > 135) || (angle < -135 && angle > -180))
        {
            ThumbstickDirStr = "{左方向：" + vector2 + "}";
        }
        //右方向    
        else if ((angle > 0 && angle < 45) || (angle > -45 && angle < 0))
        {
            ThumbstickDirStr = "{右方向：" + vector2 + "}";
        }

        txt_TouchBtnState.text = "按键状态：摇杆滑动," + ThumbstickDirStr;
    }

    /// <summary>  
    /// 根据滑动Thumbstick摇杆的位置，返回一个角度值  
    /// </summary>  
    /// <param name="from"></param>  
    /// <param name="to"></param>  
    /// <returns></returns>  
    float VectorAngle(Vector2 from, Vector2 to)
    {
        float angle;
        Vector3 cross = Vector3.Cross(from, to);
        angle = Vector2.Angle(from, to);
        return cross.z > 0 ? -angle : angle;
    }

    IEnumerator ClearTxt(Text text)
    {
        yield return new WaitForSeconds(1f);
        text.text = string.Empty;
        yield return new WaitForSeconds(1f);
        StartCoroutine(ClearTxt(text));
    }

    void FixedUpdate()
    {
        TouchTrackedData(txt_RTouchValue, OVRInput.Controller.RTouch,"右手Touch");
        TouchTrackedData(txt_LTouchValue, OVRInput.Controller.LTouch,"左手Touch");
    }

    /// <summary>
    /// 手柄Touch控制器的其他追踪参数获取
    /// </summary>
    /// <param name="txt_touchValue"></param>
    /// <param name="controller"></param>
    /// <param name="str"></param>
    void TouchTrackedData(Text txt_touchValue, OVRInput.Controller controller,string str="")
    {
    txt_touchValue.text =str+ "手柄数据："+ "\n"
            + "当前位置：" + "\n  " + OVRInput.GetLocalControllerPosition(controller) + "\n"
            + "当前旋转角度：" + "\n  " + OVRInput.GetLocalControllerRotation(controller) + "\n"
            + "当前速度：" + "\n  " + OVRInput.GetLocalControllerVelocity(controller) + "\n"
            + "当前加速度：" + "\n  " + OVRInput.GetLocalControllerAcceleration(controller) + "\n"
            + "当前角加速度：" + "\n  " + OVRInput.GetLocalControllerAngularAcceleration(controller) + "\n"
            + "当前角速度：" + "\n  " + OVRInput.GetLocalControllerAngularVelocity(controller);
    }
}
