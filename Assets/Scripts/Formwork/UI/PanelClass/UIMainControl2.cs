using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainControl2 : UIPage
{

    public UIMainControl2() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
{
    uiPath = "UIPrefab/UIMain Control2";
}

    public override void Awake(GameObject go)
    {

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Main Control2"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }


}
