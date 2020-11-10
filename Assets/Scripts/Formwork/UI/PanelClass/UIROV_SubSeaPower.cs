using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_SubSeaPower : UIPage
{
    public UIROV_SubSeaPower() : base(UIType.Fixed, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_SubSeaPower";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
        //MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV SubSea Power"));
    }

}
