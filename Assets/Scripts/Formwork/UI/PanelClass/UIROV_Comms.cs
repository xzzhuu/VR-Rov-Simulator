using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_Comms : UIPage
{
    public UIROV_Comms() : base(UIType.PopUp, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_Comms";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
       // MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV_Comms"));
    }

}
