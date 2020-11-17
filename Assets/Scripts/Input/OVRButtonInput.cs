using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//右手控制器

public delegate void OVR_RIndexTriggerPressEventHandle();
public delegate void OVR_RIndexTriggerHoldEventHandle();
public delegate void OVR_RIndexTriggerReleaseEventHandle();

public delegate void OVR_RHandTriggerPressEventHandle();
public delegate void OVR_RHandTriggerHoldEventHandle();
public delegate void OVR_RHandTriggerReleaseEventHandle();

public delegate void OVR_RButtonAPressEventHandle();
public delegate void OVR_RButtonAHoldEventHandle();
public delegate void OVR_RButtonAReleaseEventHandle();

public delegate void OVR_RButtonBPressEventHandle();
public delegate void OVR_RButtonBHoldEventHandle();
public delegate void OVR_RButtonBReleaseEventHandle();


public delegate void OVR_RThumbstickUpPressEventHandle();
public delegate void OVR_RThumbstickUpHoldEventHandle();
public delegate void OVR_RThumbstickUpReleaseEventHandle();

public delegate void OVR_RThumbstickDownPressEventHandle();
public delegate void OVR_RThumbstickDownHoldEventHandle();
public delegate void OVR_RThumbstickDownReleaseEventHandle();

public delegate void OVR_RThumbstickLeftPressEventHandle();
public delegate void OVR_RThumbstickLeftHoldEventHandle();
public delegate void OVR_RThumbstickLeftReleaseEventHandle();

public delegate void OVR_RThumbstickRightPressEventHandle();
public delegate void OVR_RThumbstickRightHoldEventHandle();
public delegate void OVR_RThumbstickRightReleaseEventHandle();

//左手控制器
public delegate void OVR_LIndexTriggerPressEventHandle();
public delegate void OVR_LIndexTriggerHoldEventHandle();
public delegate void OVR_LIndexTriggerReleaseEventHandle();

public delegate void OVR_LHandTriggerPressEventHandle();
public delegate void OVR_LHandTriggerHoldEventHandle();
public delegate void OVR_LHandTriggerReleaseEventHandle();

public delegate void OVR_LButtonXPressEventHandle();
public delegate void OVR_LButtonXHoldEventHandle();
public delegate void OVR_LButtonXReleaseEventHandle();

public delegate void OVR_LButtonYPressEventHandle();
public delegate void OVR_LButtonYHoldEventHandle();
public delegate void OVR_LButtonYReleaseEventHandle();


public delegate void OVR_LThumbstickUpPressEventHandle();
public delegate void OVR_LThumbstickUpHoldEventHandle();
public delegate void OVR_LThumbstickUpReleaseEventHandle();

public delegate void OVR_LThumbstickDownPressEventHandle();
public delegate void OVR_LThumbstickDownHoldEventHandle();
public delegate void OVR_LThumbstickDownReleaseEventHandle();

public delegate void OVR_LThumbstickLeftPressEventHandle();
public delegate void OVR_LThumbstickLeftHoldEventHandle();
public delegate void OVR_LThumbstickLeftReleaseEventHandle();

public delegate void OVR_LThumbstickRightPressEventHandle();
public delegate void OVR_LThumbstickRightHoldEventHandle();
public delegate void OVR_LThumbstickRightReleaseEventHandle();
public class OVRButtonInput : MonoBehaviour
{
    public static OVRButtonInput Instance;

    public bool OnButtonInput = false;
    void Awake()
    {
        Instance = this;
    }

    //Get() 按住多次触发事件 
    //GetDown()、GetUp()按下和抬起的时候各只触发一次
    void Update()
    {
        if (OnButtonInput)
        {
            RightTouchState();//右手Touch控制器按键事件
            LeftTouchState();//左手Touch控制器按键事件
        }
       

    }

    /*----------右手Touch控制器按键事件--------------*/
    void RightTouchState()
    {
        /*右手控制器RThumbstick按键事件（第一种方式对摇杆按键操作）*/
        //上
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp)){OnOvrRThumbstickUpPress();}
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickUp)){OnOvrRThumbstickUpHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickUp)){OnOvrRThumbstickUpRelease();}
        //下
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown)){OnOvrRThumbstickDownPress();}
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickDown)){OnOvrRThumbstickDownHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickDown)){OnOvrRThumbstickDownRelease();}
        //左
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft)){OnOvrRThumbstickLeftPress();}
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickLeft)){OnOvrRThumbstickLeftHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickLeft)){OnOvrRThumbstickLeftRelease();}
        //右
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight)){OnOvrRThumbstickRightPress();}
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickRight)){OnOvrRThumbstickRightHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickRight)){OnOvrRThumbstickRightRelease();}

        /*右手控制器RIndexTrigger扳机键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)){OnOvrRIndexTriggerPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger)){OnOvrRIndexTriggerHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger)){OnOvrRIndexTriggerRelease();}
       
        /*右手控制器RHandTrigger侧卧键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)){OnOvrRHandTriggerPress();}
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger)){ OnOvrRHandTriggerHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.RHandTrigger)){OnOvrRHandTriggerRelease();}
      
        /*右手控制器A键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.A)){OnOvrRButtonAPress();}
        if (OVRInput.Get(OVRInput.RawButton.A)){OnOvrRButtonAHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.A)){OnOvrRButtonARelease();}

        /*右手控制器B键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.B)){OnOvrRButtonBPress();}
        if (OVRInput.Get(OVRInput.RawButton.B)){OnOvrRButtonBHold();}
        if (OVRInput.GetUp(OVRInput.RawButton.B)){OnOvrRButtonBRelease();}
    }


    /*----------左手Touch控制器按键事件--------------*/
    void LeftTouchState()
    {
        /*右手控制器RThumbstick按键事件（第一种方式对摇杆按键操作）*/
        //上
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp)) { OnOvrLThumbstickUpPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LThumbstickUp)) { OnOvrLThumbstickUpHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LThumbstickUp)) { OnOvrLThumbstickUpRelease(); }
        //下
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown)) { OnOvrLThumbstickDownPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LThumbstickDown)) { OnOvrLThumbstickDownHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LThumbstickDown)) { OnOvrLThumbstickDownRelease(); }
        //左
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft)) { OnOvrLThumbstickLeftPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LThumbstickLeft)) { OnOvrLThumbstickLeftHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LThumbstickLeft)) { OnOvrLThumbstickLeftRelease(); }
        //右
        if (OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight)) { OnOvrLThumbstickRightPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LThumbstickRight)) { OnOvrLThumbstickRightHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LThumbstickRight)) { OnOvrLThumbstickRightRelease(); }

        /*右手控制器RIndexTrigger扳机键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) { OnOvrLIndexTriggerPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger)) { OnOvrLIndexTriggerHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LIndexTrigger)) { OnOvrLIndexTriggerRelease(); }

        /*右手控制器RHandTrigger侧卧键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.LHandTrigger)) { OnOvrLHandTriggerPress(); }
        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger)) { OnOvrLHandTriggerHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.LHandTrigger)) { OnOvrLHandTriggerRelease(); }

        /*右手控制器A键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.X)) { OnOvrLButtonXPress(); }
        if (OVRInput.Get(OVRInput.RawButton.X)) { OnOvrLButtonXHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.X)) { OnOvrLButtonXRelease(); }

        /*右手控制器B键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.Y)) { OnOvrLButtonYPress(); }
        if (OVRInput.Get(OVRInput.RawButton.Y)) { OnOvrLButtonYHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.Y)) { OnOvrLButtonYRelease(); }

    }

    //手柄控制器的摇杆全方位滑动控制（第二种方式对摇杆按键操作）
    void ThumbstickSlide(OVRInput.RawAxis2D Thumbstick, string ThumbstickDirStr)
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



    public event OVR_RIndexTriggerPressEventHandle OVR_RIndexTriggerPress;
    public event OVR_RIndexTriggerHoldEventHandle OVR_RIndexTriggerHold;
    public event OVR_RIndexTriggerReleaseEventHandle OVR_RIndexTriggerRelease;

    public event OVR_RHandTriggerPressEventHandle OVR_RHandTriggerPress;
    public event OVR_RHandTriggerHoldEventHandle OVR_RHandTriggerHold;
    public event OVR_RHandTriggerReleaseEventHandle OVR_RHandTriggerRelease;

    public event OVR_RButtonAPressEventHandle OVR_RButtonAPress;
    public event OVR_RButtonAHoldEventHandle OVR_RButtonAHold;
    public event OVR_RButtonAReleaseEventHandle OVR_RButtonARelease;

    public event OVR_RButtonBPressEventHandle OVR_RButtonBPress;
    public event OVR_RButtonBHoldEventHandle OVR_RButtonBHold;
    public event OVR_RButtonBReleaseEventHandle OVR_RButtonBRelease;

    public event OVR_RThumbstickUpPressEventHandle OVR_RThumbstickUpPress;
    public event OVR_RThumbstickUpHoldEventHandle OVR_RThumbstickUpHold;
    public event OVR_RThumbstickUpReleaseEventHandle OVR_RThumbstickUpRelease;

    public event OVR_RThumbstickDownPressEventHandle OVR_RThumbstickDownPress;
    public event OVR_RThumbstickDownHoldEventHandle OVR_RThumbstickDownHold;
    public event OVR_RThumbstickDownReleaseEventHandle OVR_RThumbstickDownRelease;

    public event OVR_RThumbstickLeftPressEventHandle OVR_RThumbstickLeftPress;
    public event OVR_RThumbstickLeftHoldEventHandle OVR_RThumbstickLeftHold;
    public event OVR_RThumbstickLeftReleaseEventHandle OVR_RThumbstickLeftRelease;

    public event OVR_RThumbstickRightPressEventHandle OVR_RThumbstickRightPress;
    public event OVR_RThumbstickRightHoldEventHandle OVR_RThumbstickRightHold;
    public event OVR_RThumbstickRightReleaseEventHandle OVR_RThumbstickRightRelease;

    //右手
    //上方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickUpPress()
    {
        if (this.OVR_RThumbstickUpPress != null)
        {
            OVR_RThumbstickUpPress();
        }
    }
    protected virtual void OnOvrRThumbstickUpHold()
    {
        if (this.OVR_RThumbstickUpHold != null)
        {
            OVR_RThumbstickUpHold();
        }
    }
    protected virtual void OnOvrRThumbstickUpRelease()
    {
        if (this.OVR_RThumbstickUpRelease != null)
        {
            OVR_RThumbstickUpRelease();
        }
    }
    //下方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickDownPress()
    {
        if (this.OVR_RThumbstickDownPress != null)
        {
            OVR_RThumbstickDownPress();
        }
    }
    protected virtual void OnOvrRThumbstickDownHold()
    {
        if (this.OVR_RThumbstickDownHold != null)
        {
            OVR_RThumbstickDownHold();
        }
    }
    protected virtual void OnOvrRThumbstickDownRelease()
    {
        if (this.OVR_RThumbstickDownRelease != null)
        {
            OVR_RThumbstickDownRelease();
        }
    }
    //左方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickLeftPress()
    {
        if (this.OVR_RThumbstickLeftPress != null)
        {
            OVR_RThumbstickLeftPress();
        }
    }
    protected virtual void OnOvrRThumbstickLeftHold()
    {
        if (this.OVR_RThumbstickLeftHold != null)
        {
            OVR_RThumbstickLeftHold();
        }
    }
    protected virtual void OnOvrRThumbstickLeftRelease()
    {
        if (this.OVR_RThumbstickLeftRelease != null)
        {
            OVR_RThumbstickLeftRelease();
        }
    }
    //右方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickRightPress()
    {
        if (this.OVR_RThumbstickRightPress != null)
        {
            OVR_RThumbstickRightPress();
        }
    }
    protected virtual void OnOvrRThumbstickRightHold()
    {
        if (this.OVR_RThumbstickRightHold != null)
        {
            OVR_RThumbstickRightHold();
        }
    }
    protected virtual void OnOvrRThumbstickRightRelease()
    {
        if (this.OVR_RThumbstickRightRelease != null)
        {
            OVR_RThumbstickRightRelease();
        }
    }
    //扳机键
    //按下 .按住 . 释放
    protected virtual void OnOvrRIndexTriggerPress()
    {
        if (this.OVR_RIndexTriggerPress != null)
        {
            OVR_RIndexTriggerPress();
        }
    }
    protected virtual void OnOvrRIndexTriggerHold()
    {
        if (this.OVR_RIndexTriggerHold != null)
        {
            OVR_RIndexTriggerHold();
        }
    }
    protected virtual void OnOvrRIndexTriggerRelease()
    {
        if (this.OVR_RIndexTriggerRelease != null)
        {
            OVR_RIndexTriggerRelease();
        }
    }
    //侧卧键
    //按下 .按住 . 释放
    protected virtual void OnOvrRHandTriggerPress()
    {
        if (this.OVR_RHandTriggerPress != null)
        {
            OVR_RHandTriggerPress();
        }
    }
    protected virtual void OnOvrRHandTriggerHold()
    {
        if (this.OVR_RHandTriggerHold != null)
        {
            OVR_RHandTriggerHold();
        }
    }
    protected virtual void OnOvrRHandTriggerRelease()
    {
        if (this.OVR_RHandTriggerRelease != null)
        {
            OVR_RHandTriggerRelease();
        }
    }
    //A键
    //按下 .按住 . 释放
    protected virtual void OnOvrRButtonAPress() {
        if (this.OVR_RButtonAPress != null)
        {
            OVR_RButtonAPress();
        }
    }
    protected virtual void OnOvrRButtonAHold() {
        if (this.OVR_RButtonAHold != null)
        {
            OVR_RButtonAHold();
        }
    }
    protected virtual void OnOvrRButtonARelease() {
        if (this.OVR_RButtonARelease != null)
        {
            OVR_RButtonARelease();
        }
    }
    //B键
    //按下 .按住 . 释放
    protected virtual void OnOvrRButtonBPress() {
        if (this.OVR_RButtonBPress != null)
        {
            OVR_RButtonBPress();
        }
    }
    protected virtual void OnOvrRButtonBHold() {
        if (this.OVR_RButtonBHold != null)
        {
            OVR_RButtonBHold();
        }
    }
    protected virtual void OnOvrRButtonBRelease()
    {
        if (this.OVR_RButtonBRelease != null)
        {
            OVR_RButtonBRelease();
        }
    }

    public event OVR_LIndexTriggerPressEventHandle OVR_LIndexTriggerPress;
    public event OVR_LIndexTriggerHoldEventHandle OVR_LIndexTriggerHold;
    public event OVR_LIndexTriggerReleaseEventHandle OVR_LIndexTriggerRelease;

    public event OVR_LHandTriggerPressEventHandle OVR_LHandTriggerPress;
    public event OVR_LHandTriggerHoldEventHandle OVR_LHandTriggerHold;
    public event OVR_LHandTriggerReleaseEventHandle OVR_LHandTriggerRelease;

    public event OVR_LButtonXPressEventHandle OVR_LButtonXPress;
    public event OVR_LButtonXHoldEventHandle OVR_LButtonXHold;
    public event OVR_LButtonXReleaseEventHandle OVR_LButtonXRelease;

    public event OVR_LButtonYPressEventHandle OVR_LButtonYPress;
    public event OVR_LButtonYHoldEventHandle OVR_LButtonYHold;
    public event OVR_LButtonYReleaseEventHandle OVR_LButtonYRelease;

    public event OVR_LThumbstickUpPressEventHandle OVR_LThumbstickUpPress;
    public event OVR_LThumbstickUpHoldEventHandle OVR_LThumbstickUpHold;
    public event OVR_LThumbstickUpReleaseEventHandle OVR_LThumbstickUpRelease;

    public event OVR_LThumbstickDownPressEventHandle OVR_LThumbstickDownPress;
    public event OVR_LThumbstickDownHoldEventHandle OVR_LThumbstickDownHold;
    public event OVR_LThumbstickDownReleaseEventHandle OVR_LThumbstickDownRelease;

    public event OVR_LThumbstickLeftPressEventHandle OVR_LThumbstickLeftPress;
    public event OVR_LThumbstickLeftHoldEventHandle OVR_LThumbstickLeftHold;
    public event OVR_LThumbstickLeftReleaseEventHandle OVR_LThumbstickLeftRelease;

    public event OVR_LThumbstickRightPressEventHandle OVR_LThumbstickRightPress;
    public event OVR_LThumbstickRightHoldEventHandle OVR_LThumbstickRightHold;
    public event OVR_LThumbstickRightReleaseEventHandle OVR_LThumbstickRightRelease;

    //左手
    //上方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickUpPress()
    {
        if (this.OVR_LThumbstickUpPress != null)
        {
            OVR_LThumbstickUpPress();
        }
    }
    protected virtual void OnOvrLThumbstickUpHold()
    {
        if (this.OVR_LThumbstickUpHold != null)
        {
            OVR_LThumbstickUpHold();
        }
    }
    protected virtual void OnOvrLThumbstickUpRelease()
    {
        if (this.OVR_LThumbstickUpRelease != null)
        {
            OVR_LThumbstickUpRelease();
        }
    }
    //下方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickDownPress()
    {
        if (this.OVR_LThumbstickDownPress != null)
        {
            OVR_LThumbstickDownPress();
        }
    }
    protected virtual void OnOvrLThumbstickDownHold()
    {
        if (this.OVR_LThumbstickDownHold != null)
        {
            OVR_LThumbstickDownHold();
        }
    }
    protected virtual void OnOvrLThumbstickDownRelease()
    {
        if (this.OVR_LThumbstickDownRelease != null)
        {
            OVR_LThumbstickDownRelease();
        }
    }
    //左方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickLeftPress()
    {
        if (this.OVR_LThumbstickLeftPress != null)
        {
            OVR_LThumbstickLeftPress();
        }
    }
    protected virtual void OnOvrLThumbstickLeftHold()
    {
        if (this.OVR_LThumbstickLeftHold != null)
        {
            OVR_LThumbstickLeftHold();
        }
    }
    protected virtual void OnOvrLThumbstickLeftRelease()
    {
        if (this.OVR_LThumbstickLeftRelease != null)
        {
            OVR_LThumbstickLeftRelease();
        }
    }
    //右方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickRightPress()
    {
        if (this.OVR_LThumbstickRightPress != null)
        {
            OVR_LThumbstickRightPress();
        }
    }
    protected virtual void OnOvrLThumbstickRightHold()
    {
        if (this.OVR_LThumbstickRightHold != null)
        {
            OVR_LThumbstickRightHold();
        }
    }
    protected virtual void OnOvrLThumbstickRightRelease()
    {
        if (this.OVR_LThumbstickRightRelease != null)
        {
            OVR_LThumbstickRightRelease();
        }
    }
    //扳机键
    //按下 .按住 . 释放
    protected virtual void OnOvrLIndexTriggerPress()
    {
        if (this.OVR_LIndexTriggerPress != null)
        {
            OVR_LIndexTriggerPress();
        }
    }
    protected virtual void OnOvrLIndexTriggerHold()
    {
        if (this.OVR_LIndexTriggerHold != null)
        {
            OVR_LIndexTriggerHold();
        }
    }
    protected virtual void OnOvrLIndexTriggerRelease()
    {
        if (this.OVR_LIndexTriggerRelease != null)
        {
            OVR_LIndexTriggerRelease();
        }
    }
    //侧卧键
    //按下 .按住 . 释放
    protected virtual void OnOvrLHandTriggerPress()
    {
        if (this.OVR_LHandTriggerPress != null)
        {
            OVR_LHandTriggerPress();
        }
    }
    protected virtual void OnOvrLHandTriggerHold()
    {
        if (this.OVR_LHandTriggerHold != null)
        {
            OVR_LHandTriggerHold();
        }
    }
    protected virtual void OnOvrLHandTriggerRelease()
    {
        if (this.OVR_LHandTriggerRelease != null)
        {
            OVR_LHandTriggerRelease();
        }
    }
    //X键
    //按下 .按住 . 释放
    protected virtual void OnOvrLButtonXPress()
    {
        if (this.OVR_LButtonXPress != null)
        {
            OVR_LButtonXPress();
        }
    }
    protected virtual void OnOvrLButtonXHold()
    {
        if (this.OVR_LButtonXHold != null)
        {
            OVR_LButtonXHold();
        }
    }
    protected virtual void OnOvrLButtonXRelease()
    {
        if (this.OVR_LButtonXRelease != null)
        {
            OVR_LButtonXRelease();
        }
    }
    //Y键
    //按下 .按住 . 释放
    protected virtual void OnOvrLButtonYPress()
    {
        if (this.OVR_LButtonYPress != null)
        {
            OVR_LButtonYPress();
        }
    }
    protected virtual void OnOvrLButtonYHold()
    {
        if (this.OVR_LButtonYHold != null)
        {
            OVR_LButtonYHold();
        }
    }
    protected virtual void OnOvrLButtonYRelease()
    {
        if (this.OVR_LButtonYRelease != null)
        {
            OVR_LButtonYRelease();
        }
    }
}