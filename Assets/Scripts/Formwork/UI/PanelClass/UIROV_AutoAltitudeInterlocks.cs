using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_AutoAltitudeInterlocks : UIPage
{
    public UIROV_AutoAltitudeInterlocks() : base(UIType.PopUp, UIMode.DoNothing)
    {
        uiPath = "UIPrefab/UIROV_AutoAltitudeInterlocks";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
       // MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS SubSea Power"));
      
    }
}
