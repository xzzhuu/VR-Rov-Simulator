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
       
    }

    void RTouchAHold()
    {
       
    }

    void RTouchBHold()
    {
       
    }
    void RTouchThumbstickUpHold()
    {
     
    }
    void RTouchThumbstickDownHold()
    {
      
    }
    void RTouchThumbstickLeftHold()
    {
     
    }
    void RTouchThumbstickRightHold()
    {
     
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
