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
        OVRBtnInputMgr.Instance.OVR_RHandTriggerHold -= RTouchHandTriggerHold;
        OVRBtnInputMgr.Instance.OVR_RButtonAHold -= RTouchAHold;
        OVRBtnInputMgr.Instance.OVR_RButtonBHold -= RTouchBHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickUpHold -= RTouchThumbstickUpHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickDownHold -= RTouchThumbstickDownHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickLeftHold -= RTouchThumbstickLeftHold;
        OVRBtnInputMgr.Instance.OVR_RThumbstickRightHold -= RTouchThumbstickRightHold;
    }
 
}
