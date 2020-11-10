using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAutoPitch_Roll :UIPage
{

    public UIAutoPitch_Roll() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIAuto Pitch_Roll";
    }

    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Auto Pitch/Roll"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
