using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIQuickFunctionConfiguration : UIPage
{

    public UIQuickFunctionConfiguration() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIQuickFunction Configuration";
    }

    public override void Awake(GameObject go)
    {

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("QuickFunction Configuration"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
