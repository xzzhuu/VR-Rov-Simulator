using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMobilisation : UIPage
{
   public UIMobilisation():base(UIType.Normal,UIMode.HideOther)
    {
        uiPath = "UIPrefab/UIMobilisation";
    }

    public override void Awake(GameObject go)
    {
        base.Awake(go);
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Mobilisation"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
