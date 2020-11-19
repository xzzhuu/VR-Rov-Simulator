using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMainControl1 : UIPage
{
    Slider sd_VO;
    Slider sd_TO;

    Toggle tg_VOLoadPump;
    Toggle tg_ThrustEnable;
    Toggle tg_STBDMainipulator;

    Toggle tg_VehicleReverse;
    Toggle tg_AutoHeadingSelect;
    Toggle tg_AdvancedControl;

    Toggle tg_TOLoadPump;
    Toggle tg_PortManip;


    public UIMainControl1() : base(UIType.Normal, UIMode.HideOther)
    {
        uiPath = "UIPrefab/UIMain Control1";
    }

    public override void Awake(GameObject go)
    {
        sd_VO = this.transform.Find("bg_left/ruler/Slider").GetComponent<Slider>();
        sd_TO = this.transform.Find("bg_right/ruler/Slider").GetComponent<Slider>();
        tg_VOLoadPump = this.transform.Find("bg_left/tgs/tg_LoadPump").GetComponent<Toggle>();
        tg_ThrustEnable= this.transform.Find("bg_left/tgs/tg_Thrust Enable").GetComponent<Toggle>();
        tg_STBDMainipulator= this.transform.Find("bg_left/tgs/tg_STBD Mainipulator").GetComponent<Toggle>(); ;
        tg_VehicleReverse= this.transform.Find("bg_middle/tg_Vehicle Reverse").GetComponent<Toggle>(); ;
        tg_AutoHeadingSelect= this.transform.Find("bg_middle/tg_Auto Heading Select").GetComponent<Toggle>(); ;
        tg_AdvancedControl= this.transform.Find("bg_middle/tg_Advanced Control").GetComponent<Toggle>(); ;
        tg_TOLoadPump= this.transform.Find("bg_right/tgs/tg_LoadPump").GetComponent<Toggle>();
        tg_PortManip= this.transform.Find("bg_right/tgs/tg_Port Manip").GetComponent<Toggle>();

      
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Main Control1"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }

    bool isNotValueSlider(Slider slider)
    {
        if (slider.value != 0f) return true;
        return false;
    }
}

