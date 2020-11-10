using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LTouchController : TouchControllerBase {

    private LTouchCtlType leftControl = LTouchCtlType.None;
    public LTouchCtlType LeftControl{ get => leftControl; set => leftControl = value; }

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
       
        //OVRButtonInput.Instance.OVR_LIndexTriggerHold += LTouchIndexTriggerHold;
        //OVRTouchInput.OVR_LIndexTriggerRelease+=

        //OVRTouchInput.OVR_LHandTriggerPress +=;
        OVRButtonInput.Instance.OVR_LHandTriggerHold +=LTouchHandTriggerHold;
        //OVRTouchInput.OVR_LHandTriggerRelease+=

        //OVRTouchInput.OVR_LButtonXPress+=
        OVRButtonInput.Instance.OVR_LButtonXHold += LTouchXHold;
        OVRButtonInput.Instance.OVR_LButtonXRelease += LTouchXRelease;

        //OVRTouchInput.OVR_LButtonYPress+=
        OVRButtonInput.Instance.OVR_LButtonYHold += LTouchYHold;
        OVRButtonInput.Instance.OVR_LButtonYRelease += LTouchYRelease;

        //OVRTouchInput.OVR_LThumbstickUpPress+=
        OVRButtonInput.Instance.OVR_LThumbstickUpHold += LTouchThumbstickUpHold;
        //OVRTouchInput.OVR_LThumbstickUpRelease+=

        //OVRTouchInput.OVR_LThumbstickDownPress+=
        OVRButtonInput.Instance.OVR_LThumbstickDownHold += LTouchThumbstickDownHold;
        //OVRTouchInput.OVR_LThumbstickDownRelease+=

        //OVRTouchInput.OVR_LThumbstickLeftPress+=
        OVRButtonInput.Instance.OVR_LThumbstickLeftHold += LTouchThumbstickLeftHold;
        //OVRTouchInput.OVR_LThumbstickLeftRelease+=

        //OVRTouchInput.OVR_LThumbstickRightPress+=
        OVRButtonInput.Instance.OVR_LThumbstickRightHold += LTouchThumbstickRightHold;
        //OVRTouchInput.OVR_LThumbstickRightRelease+=
    }

    void LTouchIndexTriggerHold()
    {
       
    }
    void LTouchHandTriggerHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
                robotControl.FlotControl(false);
                break;
            case LTouchCtlType.L2:
                robotControl.RotateGripper(ARMDIR.TurnL);
                break;
            default:
                break;
        }
    }

    void LTouchXHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
                //TODO 增加绳子的长度
                tmsRopeControl.RopeCtl(RopeDir.Add);
                break;
            case LTouchCtlType.L2:
                robotControl.OpenCloseGripper(ARMDIR.Out);
                break;
            default:
                break;
        }
    }
    void LTouchXRelease()
    {
        if(LeftControl== LTouchCtlType.L1)
        {
            tmsRopeControl.RopeCtl(RopeDir.Default);
        }
    }
    void LTouchYHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
                //TODO 减小绳子的长度
                tmsRopeControl.RopeCtl(RopeDir.Reduce);
                break;
            case LTouchCtlType.L2:
                robotControl.OpenCloseGripper(ARMDIR.In);
                break;
            default:
                break;
        }
    }
    void LTouchYRelease()
    {
        if (LeftControl == LTouchCtlType.L1)
        {
            tmsRopeControl.RopeCtl(RopeDir.Default);
        }
    }
    void LTouchThumbstickUpHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
              //  robotControl.MoveROVInVertical(DIR.Up);
                break;
            case LTouchCtlType.L2:
                robotControl.MoveArm(ARMDIR.Up);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickDownHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
              //  robotControl.MoveROVInVertical(DIR.Down);
                break;
            case LTouchCtlType.L2:
                robotControl.MoveArm(ARMDIR.Down);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickLeftHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
                //robotControl.RotateROV(DIR.TurnL);
                break;
            case LTouchCtlType.L2:
                robotControl.MoveArm(ARMDIR.Left);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickRightHold()
    {
        switch (LeftControl)
        {
            case LTouchCtlType.L1:
               // robotControl.RotateROV(DIR.TurnR);
                break;
            case LTouchCtlType.L2:
                robotControl.MoveArm(ARMDIR.Right);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 判断当前控制器的功能输入方式
    /// </summary>
    /// <param name="lTouchType"></param>
    /// <returns></returns>
    protected virtual bool IsCurrentLTouchCtlType(LTouchCtlType lTouchType)
    {
        return LeftControl == lTouchType ? true : false;
    }
    public enum LTouchCtlType
    {
        None,
        L1,
        L2,
        L3
    }
}
