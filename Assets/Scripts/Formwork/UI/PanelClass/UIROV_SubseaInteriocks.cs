using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_SubseaInteriocks : UIPage
{
    public UIROV_SubseaInteriocks() : base(UIType.PopUp, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_SubseaInteriocks";
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
