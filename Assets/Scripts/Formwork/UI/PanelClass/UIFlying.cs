using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFlying : UIPage
{

    public UIFlying() : base(UIType.DataScreen, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIFlying";
    }

    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Flying"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
    }
}
