using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystemStatus : UIPage
{

    public UISystemStatus() : base(UIType.DataScreen, UIMode.HideSameOther, UICollider.None)
    {
        uiPath = "UIPrefab/UISystemStatus";
    }

    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("System Status"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
    }
}
