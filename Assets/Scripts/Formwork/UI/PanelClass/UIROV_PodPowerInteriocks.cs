using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_PodPowerInteriocks : UIPage
{
    public UIROV_PodPowerInteriocks() : base(UIType.PopUp, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_PodPowerInteriocks";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        //MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS SubSea Power"));
    }

}

