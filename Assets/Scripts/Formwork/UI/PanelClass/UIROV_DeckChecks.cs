using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROV_DeckChecks : UIPage
{
    public UIROV_DeckChecks() : base(UIType.PopUp, UIMode.DoNothing, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV_DeckChecks";
    }


    public override void Awake(GameObject go)
    {

    }
    public override void Active()
    {
        base.Active();
       // MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Deck Checks"));
    }

}

