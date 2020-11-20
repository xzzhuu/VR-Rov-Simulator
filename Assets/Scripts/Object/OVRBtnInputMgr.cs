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
public class OVRBtnInputMgr : MonoSingleton<OVRBtnInputMgr>
{
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

    private bool isInputRov = false;//手柄是否能操作ROV
    public bool IsInputRov { get => isInputRov; set => isInputRov = value; }
    //Get() 按住多次触发事件 
    //GetDown()、GetUp()按下和抬起的时候各只触发一次
    void Update()
    {
        if (!IsInputRov) return;
        RControllerInput();//右手Touch控制器按键事件
        LControllerInput();//左手Touch控制器按键事件
    }

    /*----------右手Touch控制器按键事件--------------*/
    void RControllerInput()
    {
        /*右手控制器RThumbstick按键事件（第一种方式对摇杆按键操作）*/
        //上
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp)) { OnOvrRThumbstickUpPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickUp)) { OnOvrRThumbstickUpHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickUp)) { OnOvrRThumbstickUpRelease(); }
        //下
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown)) { OnOvrRThumbstickDownPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickDown)) { OnOvrRThumbstickDownHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickDown)) { OnOvrRThumbstickDownRelease(); }
        //左
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft)) { OnOvrRThumbstickLeftPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickLeft)) { OnOvrRThumbstickLeftHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickLeft)) { OnOvrRThumbstickLeftRelease(); }
        //右
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight)) { OnOvrRThumbstickRightPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RThumbstickRight)) { OnOvrRThumbstickRightHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RThumbstickRight)) { OnOvrRThumbstickRightRelease(); }

        /*右手控制器RIndexTrigger扳机键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) { OnOvrRIndexTriggerPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger)) { OnOvrRIndexTriggerHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger)) { OnOvrRIndexTriggerRelease(); }

        /*右手控制器RHandTrigger侧卧键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)) { OnOvrRHandTriggerPress(); }
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger)) { OnOvrRHandTriggerHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.RHandTrigger)) { OnOvrRHandTriggerRelease(); }

        /*右手控制器A键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.A)) { OnOvrRButtonAPress(); }
        if (OVRInput.Get(OVRInput.RawButton.A)) { OnOvrRButtonAHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.A)) { OnOvrRButtonARelease(); }

        /*右手控制器B键按键事件*/
        if (OVRInput.GetDown(OVRInput.RawButton.B)) { OnOvrRButtonBPress(); }
        if (OVRInput.Get(OVRInput.RawButton.B)) { OnOvrRButtonBHold(); }
        if (OVRInput.GetUp(OVRInput.RawButton.B)) { OnOvrRButtonBRelease(); }
    }


    /*----------左手Touch控制器按键事件--------------*/
    void LControllerInput()
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
    //右手
    //上方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickUpPress()
    {
            OVR_RThumbstickUpPress?.Invoke();
    }
    protected virtual void OnOvrRThumbstickUpHold()
    {
            OVR_RThumbstickUpHold?.Invoke();
    }
    protected virtual void OnOvrRThumbstickUpRelease()
    {
            OVR_RThumbstickUpRelease?.Invoke();
    }
    //下方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickDownPress()
    {
            OVR_RThumbstickDownPress?.Invoke();
    }
    protected virtual void OnOvrRThumbstickDownHold()
    {
            OVR_RThumbstickDownHold?.Invoke();
    }
    protected virtual void OnOvrRThumbstickDownRelease()
    {
            OVR_RThumbstickDownRelease?.Invoke();
    }
    //左方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickLeftPress()
    {
            OVR_RThumbstickLeftPress?.Invoke();
    }
    protected virtual void OnOvrRThumbstickLeftHold()
    {
            OVR_RThumbstickLeftHold?.Invoke();
    }
    protected virtual void OnOvrRThumbstickLeftRelease()
    {
            OVR_RThumbstickLeftRelease?.Invoke();
    }
    //右方向
    //按下 .按住 . 释放
    protected virtual void OnOvrRThumbstickRightPress()
    {
            OVR_RThumbstickRightPress?.Invoke();
    }
    protected virtual void OnOvrRThumbstickRightHold()
    {
            OVR_RThumbstickRightHold?.Invoke();
    }
    protected virtual void OnOvrRThumbstickRightRelease()
    {
            OVR_RThumbstickRightRelease?.Invoke();
    }
    //扳机键
    //按下 .按住 . 释放
    protected virtual void OnOvrRIndexTriggerPress()
    {
            OVR_RIndexTriggerPress?.Invoke();
    }
    protected virtual void OnOvrRIndexTriggerHold()
    {
            OVR_RIndexTriggerHold?.Invoke();
    }
    protected virtual void OnOvrRIndexTriggerRelease()
    {
            OVR_RIndexTriggerRelease?.Invoke();
    }
    //侧卧键
    //按下 .按住 . 释放
    protected virtual void OnOvrRHandTriggerPress()
    {
            OVR_RHandTriggerPress?.Invoke();
    }
    protected virtual void OnOvrRHandTriggerHold()
    {
            OVR_RHandTriggerHold?.Invoke();
    }
    protected virtual void OnOvrRHandTriggerRelease()
    {
            OVR_RHandTriggerRelease?.Invoke();
    }
    //A键
    //按下 .按住 . 释放
    protected virtual void OnOvrRButtonAPress()
    {
            OVR_RButtonAPress?.Invoke();
       
    }
    protected virtual void OnOvrRButtonAHold()
    {
            OVR_RButtonAHold?.Invoke();
    }
    protected virtual void OnOvrRButtonARelease()
    {
            OVR_RButtonARelease?.Invoke();
        
    }
    //B键
    //按下 .按住 . 释放
    protected virtual void OnOvrRButtonBPress()
    {
            OVR_RButtonBPress?.Invoke();
    }
    protected virtual void OnOvrRButtonBHold()
    {
            OVR_RButtonBHold?.Invoke();
    }
    protected virtual void OnOvrRButtonBRelease()
    {
            OVR_RButtonBRelease?.Invoke();
    }
    //------------左手柄控制-------------------------------
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
        OVR_LThumbstickUpPress?.Invoke();
    }
    protected virtual void OnOvrLThumbstickUpHold()
    {
        OVR_LThumbstickUpHold?.Invoke();
    }
    protected virtual void OnOvrLThumbstickUpRelease()
    {
            OVR_LThumbstickUpRelease?.Invoke();
    }
    //下方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickDownPress()
    {
        OVR_LThumbstickDownPress?.Invoke();
    }
    protected virtual void OnOvrLThumbstickDownHold()
    {
        OVR_LThumbstickDownHold?.Invoke();
    }
    protected virtual void OnOvrLThumbstickDownRelease()
    {
        OVR_LThumbstickDownRelease?.Invoke();
    }
    //左方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickLeftPress()
    {
        OVR_LThumbstickLeftPress?.Invoke();
    }
    protected virtual void OnOvrLThumbstickLeftHold()
    {
        OVR_LThumbstickLeftHold?.Invoke();
    }
    protected virtual void OnOvrLThumbstickLeftRelease()
    {
        OVR_LThumbstickLeftRelease?.Invoke();
    }
    //右方向
    //按下 .按住 . 释放
    protected virtual void OnOvrLThumbstickRightPress()
    {
        OVR_LThumbstickRightPress?.Invoke();
    }
    protected virtual void OnOvrLThumbstickRightHold()
    {
        OVR_LThumbstickRightHold?.Invoke();
    }
    protected virtual void OnOvrLThumbstickRightRelease()
    {

        OVR_LThumbstickRightRelease?.Invoke();
    }
    //扳机键
    //按下 .按住 . 释放
    protected virtual void OnOvrLIndexTriggerPress()
    {
        OVR_LIndexTriggerPress?.Invoke();
    }
    protected virtual void OnOvrLIndexTriggerHold()
    {
        OVR_LIndexTriggerHold?.Invoke();
    }
    protected virtual void OnOvrLIndexTriggerRelease()
    {
        OVR_LIndexTriggerRelease?.Invoke();
    }
    //侧卧键
    //按下 .按住 . 释放
    protected virtual void OnOvrLHandTriggerPress()
    {
        OVR_LHandTriggerPress?.Invoke();

    }
    protected virtual void OnOvrLHandTriggerHold()
    {
        OVR_LHandTriggerHold?.Invoke();
    }
    protected virtual void OnOvrLHandTriggerRelease()
    {
        OVR_LHandTriggerRelease?.Invoke();
    }
    //X键
    //按下 .按住 . 释放
    protected virtual void OnOvrLButtonXPress()
    {
        OVR_LButtonXPress?.Invoke();
    }
    protected virtual void OnOvrLButtonXHold()
    {
        OVR_LButtonXHold?.Invoke();
    }
    protected virtual void OnOvrLButtonXRelease()
    {
        OVR_LButtonXRelease?.Invoke();
    }
    //Y键
    //按下 .按住 . 释放
    protected virtual void OnOvrLButtonYPress()
    {
        OVR_LButtonYPress?.Invoke();
    }
    protected virtual void OnOvrLButtonYHold()
    {
        OVR_LButtonYHold?.Invoke();
    }
    protected virtual void OnOvrLButtonYRelease()
    {
        OVR_LButtonYRelease?.Invoke();
    }

    private void OnDestroy()
    {
      //  OVR_LButtonYRelease?.;
    }
}