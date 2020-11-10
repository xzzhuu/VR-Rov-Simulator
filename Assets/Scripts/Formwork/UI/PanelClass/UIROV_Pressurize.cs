using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_Pressurize : UIPage
{
    public UIROV_Pressurize() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_Pressurize";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Pressurize"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
      
    }
}
