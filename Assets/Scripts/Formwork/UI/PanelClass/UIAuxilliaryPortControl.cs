using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAuxilliaryPortControl : UIPage
{

    public UIAuxilliaryPortControl() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIAuxilliary Port Control";
    }

    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Auxilliary Port Control"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
