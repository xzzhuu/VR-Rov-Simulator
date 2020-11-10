using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPilotFightScreen : UIPage
{

    public UIPilotFightScreen() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIPilot Fight Screen";
    }

    public override void Awake(GameObject go)
    {

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Pilot Fight Screen"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
