using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIROVDesk : UIPage
{
    Toggle tg_rovpod;
    Toggle tg_rovmotor;
    Toggle tg_depth;
    Toggle tg_altitude;
    Toggle tg_heading;
    Toggle tg_position;
    public UIROVDesk() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROVDesk";
    }

    public override void Awake(GameObject go)
    {
        tg_rovpod = this.transform.Find("img_pod/tg_pod").GetComponent<Toggle>();
        tg_rovmotor = this.transform.Find("img_motor/tg_motor").GetComponent<Toggle>();
        tg_heading = this.transform.Find("Img_auto_functions/tg_heading").GetComponent<Toggle>();
        tg_position = this.transform.Find("Img_auto_functions/tg_position").GetComponent<Toggle>();
        tg_altitude = this.transform.Find("Img_auto_functions/tg_altitude").GetComponent<Toggle>();
        tg_depth = this.transform.Find("Img_auto_functions/tg_depth").GetComponent<Toggle>();
        ROVStateData.GetInstance().CheckTotalSettingEvent += IsUIROVDeskCompeleSet;
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Desk"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
       
    }

    public bool IsUIROVDeskCompeleSet()
    {
        if (tg_rovpod.isOn && tg_rovmotor.isOn &&isSelectOneSet()) return ROVStateData.SetF_ROVDesk1 = true;
        return ROVStateData.SetF_ROVDesk1 = false;
    }
    bool isSelectOneSet()
    {
        if (tg_altitude.isOn||tg_depth.isOn||tg_position.isOn||tg_heading.isOn) return true;
        return false;
    }
}
