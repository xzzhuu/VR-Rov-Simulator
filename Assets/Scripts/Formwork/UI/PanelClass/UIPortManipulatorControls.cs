using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPortManipulatorControls : UIPage
{

    public UIPortManipulatorControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIPort Manipulator Controls";
    }

    public override void Awake(GameObject go)
    {

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Port Manipulator Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
