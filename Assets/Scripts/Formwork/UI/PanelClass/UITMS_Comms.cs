using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITMS_Comms : UIPage
{
    public UITMS_Comms() : base(UIType.PopUp, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UITMS_Comms";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        //MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS Commons"));
    }

}