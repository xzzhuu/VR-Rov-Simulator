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

    void LTouchIndexTriggerHold()
    {
       
    }
    void LTouchHandTriggerHold()
    {
     
    }

    void LTouchXHold()
    {
       
    }
    void LTouchXRelease()
    {
    }
    void LTouchYHold()
    {
        
    }
    void LTouchYRelease()
    {
       
    }
    void LTouchThumbstickUpHold()
    {
      
    }
    void LTouchThumbstickDownHold()
    {
    
    }
    void LTouchThumbstickLeftHold()
    {
     
    }
    void LTouchThumbstickRightHold()
    {
     
      
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
