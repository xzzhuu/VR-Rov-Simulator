using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RTouchController : TouchControllerBase
{
    //具体右手柄每个按键的功能逻辑
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        OVRBtnInputMgr.Instance.OVR_RHandTriggerHold += RTouchHandTriggerHold;
        OVRBtnInputMgr.Instance.OVR_RButtonAHold += RTouchAHold;
        OVRBtnInputMgr.Instance.OVR_RButtonBHold += RTouchBHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickUpHold += RTouchThumbstickUpHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickDownHold += RTouchThumbstickDownHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickLeftHold += RTouchThumbstickLeftHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickRightHold += RTouchThumbstickRightHold;
       
    }
    //侧握键用于各个按键使用说明
    void RTouchHandTriggerHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:

                break;
            case InputMode.Gripper:

                break;
            default:
                break;
        }
    }
    void RTouchAHold()
    {

        switch (HandUIMgr.Instance.InputMode)
        {
            
            case InputMode.ROV:
                robotControl.ROVRotatePoseCtl(DIR.TurnL);
                break;
            case InputMode.Gripper:
                robotControl.GripperRotatePoseCtl(ARMDIR.TurnL);
                break;
            default:
                break;
        }
    }
    void RTouchBHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                robotControl.ROVRotatePoseCtl(DIR.TurnR);
                break;
            case InputMode.Gripper:
                robotControl.GripperRotatePoseCtl(ARMDIR.TurnR);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickUpHold()
    {
        //  Debug.Log("按住RTouchThumbstick键");
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                robotControl.ROVMovementPoseCtl(DIR.Foward);
                break;
            case InputMode.Gripper:
                robotControl.ArmMovementPoseCtl(ARMDIR.Up);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickDownHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                robotControl.ROVMovementPoseCtl(DIR.Back);
                break;
            case InputMode.Gripper:
                robotControl.ArmMovementPoseCtl(ARMDIR.Down);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickLeftHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
           
            case InputMode.ROV:
                robotControl.ROVMovementPoseCtl(DIR.Left);
                break;
            case InputMode.Gripper:
                robotControl.ArmMovementPoseCtl(ARMDIR.Left);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickRightHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                robotControl.ROVMovementPoseCtl(DIR.Right);
                break;
            case InputMode.Gripper:
                robotControl.ArmMovementPoseCtl(ARMDIR.Right);
                break;
            default:
                break;
        }
    }
    void OnDestroy()
    {
        OVRBtnInputMgr.Instance.OVR_RHandTriggerHold -= RTouchHandTriggerHold;
        OVRBtnInputMgr.Instance.OVR_RButtonAHold -= RTouchAHold;
        OVRBtnInputMgr.Instance.OVR_RButtonBHold -= RTouchBHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickUpHold -= RTouchThumbstickUpHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickDownHold -= RTouchThumbstickDownHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickLeftHold -= RTouchThumbstickLeftHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickRightHold -= RTouchThumbstickRightHold;
    }
}
