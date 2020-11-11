using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RTouchController : TouchControllerBase
{
    //具体右手柄每个按键的功能逻辑
    private RTouchCtlType rightControl = RTouchCtlType.None;
    public RTouchCtlType RightControl{ get => rightControl; set => rightControl = value; }

    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        OVRButtonInput.Instance.OVR_RHandTriggerHold += RTouchHandTriggerHold;
        OVRButtonInput.Instance.OVR_RButtonAHold += RTouchAHold;
        OVRButtonInput.Instance.OVR_RButtonBHold += RTouchBHold;
        OVRButtonInput.Instance.OVR_RThumbstickUpHold += RTouchThumbstickUpHold;
        OVRButtonInput.Instance.OVR_RThumbstickDownHold += RTouchThumbstickDownHold;
        OVRButtonInput.Instance.OVR_RThumbstickLeftHold += RTouchThumbstickLeftHold;
        OVRButtonInput.Instance.OVR_RThumbstickRightHold += RTouchThumbstickRightHold;
       
    }
    void RTouchHandTriggerHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.FlotControl(true);
                break;
            case RTouchCtlType.R2:
                robotControl.RotateGripper(ARMDIR.TurnR);
                break;
            default:
                break;
        }
    }

    void RTouchAHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.RotateROV(DIR.TurnR);
                break;
            case RTouchCtlType.R2:
                robotControl.StretchArm(ARMDIR.Long);
                break;
            default:
                break;
        }
    }

    void RTouchBHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.RotateROV(DIR.TurnL);
                break;
            case RTouchCtlType.R2:
                robotControl.StretchArm(ARMDIR.Short);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickUpHold()
    {
      //  Debug.Log("按住RTouchThumbstick键");
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                Debug.Log("---向前移动ROV");
                robotControl.MoveROVInHorizontal(DIR.Foward);
                break;
            case RTouchCtlType.R2:
                robotControl.PanTiltCamRotate(DIR.Foward);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickDownHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.MoveROVInHorizontal(DIR.Back);
                break;
            case RTouchCtlType.R2:
                robotControl.PanTiltCamRotate(DIR.Back);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickLeftHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.MoveROVInHorizontal(DIR.Left);
                break;
            case RTouchCtlType.R2:
                robotControl.PanTiltCamRotate(DIR.Left);
                break;
            default:
                break;
        }
    }
    void RTouchThumbstickRightHold()
    {
        switch (RightControl)
        {
            case RTouchCtlType.R1:
                robotControl.MoveROVInHorizontal(DIR.Right);
                break;
            case RTouchCtlType.R2:
                robotControl.PanTiltCamRotate(DIR.Right);
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 判断当前控制器的功能输入方式
    /// </summary>
    /// <param name="RTouchType"></param>
    /// <returns></returns>
    protected virtual bool IsCurrentRTouchCtlType(RTouchCtlType RTouchType)
    {
        return RightControl == RTouchType ? true : false;
    }
    public enum RTouchCtlType
    {
        None,
        R1,
        R2,
        R3
    }

    void OnDestroy()
    {
        OVRButtonInput.Instance.OVR_RHandTriggerHold -= RTouchHandTriggerHold;
        OVRButtonInput.Instance.OVR_RButtonAHold -= RTouchAHold;
        OVRButtonInput.Instance.OVR_RButtonBHold -= RTouchBHold;
        OVRButtonInput.Instance.OVR_RThumbstickUpHold -= RTouchThumbstickUpHold;
        OVRButtonInput.Instance.OVR_RThumbstickDownHold -= RTouchThumbstickDownHold;
        OVRButtonInput.Instance.OVR_RThumbstickLeftHold -= RTouchThumbstickLeftHold;
        OVRButtonInput.Instance.OVR_RThumbstickRightHold -= RTouchThumbstickRightHold;
    }
 
}
