using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LTouchController : TouchControllerBase {

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        OVRBtnInputMgr.Instance.OVR_LHandTriggerHold +=LTouchHandTriggerHold;
        OVRBtnInputMgr.Instance.OVR_LButtonXHold += LTouchXHold;
        OVRBtnInputMgr.Instance.OVR_LButtonXRelease += LTouchXRelease;
        OVRBtnInputMgr.Instance.OVR_LButtonYHold += LTouchYHold;
        OVRBtnInputMgr.Instance.OVR_LButtonYRelease += LTouchYRelease;
        OVRBtnInputMgr.Instance.OVR_LThumbstickUpHold += LTouchThumbstickUpHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickDownHold += LTouchThumbstickDownHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickLeftHold += LTouchThumbstickLeftHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickRightHold += LTouchThumbstickRightHold;
    }
    void LTouchHandTriggerHold()
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

    void LTouchXHold()
    {

        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                //收绳子
                robotControl.ROVMovementPoseCtl(DIR.Up);
                break;
            case InputMode.Gripper:
                robotControl.GripperOpeningCtl(ARMDIR.Out);
                break;
            default:
                break;
        }
    }
    void LTouchXRelease()
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
    void LTouchYHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                //放绳子
                robotControl.ROVMovementPoseCtl(DIR.Down);
                break;
            case InputMode.Gripper:
                robotControl.GripperOpeningCtl(ARMDIR.In);
                break;
            default:
                break;
        }
    }
    void LTouchYRelease()
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
    void LTouchThumbstickUpHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                break;
            case InputMode.Gripper:
                robotControl.ArmStretch(ARMDIR.Long);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickDownHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                break;
            case InputMode.Gripper:
                robotControl.ArmStretch(ARMDIR.Short);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickLeftHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                break;
            case InputMode.Gripper:
                robotControl.FlotCtl(false);
                break;
            default:
                break;
        }
    }
    void LTouchThumbstickRightHold()
    {
        switch (HandUIMgr.Instance.InputMode)
        {
            case InputMode.ROV:
                break;
            case InputMode.Gripper:
                robotControl.FlotCtl(true);
                break;
        }
    }

    private void OnDestroy()
    {
        OVRBtnInputMgr.Instance.OVR_LHandTriggerHold -= LTouchHandTriggerHold;
        OVRBtnInputMgr.Instance.OVR_LButtonXHold -= LTouchXHold;
        OVRBtnInputMgr.Instance.OVR_LButtonXRelease -= LTouchXRelease;
        OVRBtnInputMgr.Instance.OVR_LButtonYHold -= LTouchYHold;
        OVRBtnInputMgr.Instance.OVR_LButtonYRelease -= LTouchYRelease;
        OVRBtnInputMgr.Instance.OVR_LThumbstickUpHold -= LTouchThumbstickUpHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickDownHold -= LTouchThumbstickDownHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickLeftHold -= LTouchThumbstickLeftHold;
        OVRBtnInputMgr.Instance.OVR_LThumbstickRightHold -= LTouchThumbstickRightHold;
    }
}
