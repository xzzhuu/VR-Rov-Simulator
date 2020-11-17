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
       
        
        OVRButtonInput.Instance.OVR_LHandTriggerHold +=LTouchHandTriggerHold;
        OVRButtonInput.Instance.OVR_LButtonXHold += LTouchXHold;
        OVRButtonInput.Instance.OVR_LButtonXRelease += LTouchXRelease;
        OVRButtonInput.Instance.OVR_LButtonYHold += LTouchYHold;
        OVRButtonInput.Instance.OVR_LButtonYRelease += LTouchYRelease;
        OVRButtonInput.Instance.OVR_LThumbstickUpHold += LTouchThumbstickUpHold;
        OVRButtonInput.Instance.OVR_LThumbstickDownHold += LTouchThumbstickDownHold;
        OVRButtonInput.Instance.OVR_LThumbstickLeftHold += LTouchThumbstickLeftHold;
        OVRButtonInput.Instance.OVR_LThumbstickRightHold += LTouchThumbstickRightHold;
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
        OVRButtonInput.Instance.OVR_LHandTriggerHold -= LTouchHandTriggerHold;
        OVRButtonInput.Instance.OVR_LButtonXHold -= LTouchXHold;
        OVRButtonInput.Instance.OVR_LButtonXRelease -= LTouchXRelease;
        OVRButtonInput.Instance.OVR_LButtonYHold -= LTouchYHold;
        OVRButtonInput.Instance.OVR_LButtonYRelease -= LTouchYRelease;
        OVRButtonInput.Instance.OVR_LThumbstickUpHold -= LTouchThumbstickUpHold;
        OVRButtonInput.Instance.OVR_LThumbstickDownHold -= LTouchThumbstickDownHold;
        OVRButtonInput.Instance.OVR_LThumbstickLeftHold -= LTouchThumbstickLeftHold;
        OVRButtonInput.Instance.OVR_LThumbstickRightHold -= LTouchThumbstickRightHold;
    }
}
