using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITMSMainControl1 : UIPage
{
    Toggle tg_latch_open;
    Toggle tg_snubber_raise;
    Toggle tg_drum_and_lamp2;
    Toggle tg_sheave_and_lamp4;
    public UITMSMainControl1() : base(UIType.Normal, UIMode.HideOther)
    {
        uiPath = "UIPrefab/UITMSMainControl1";
    }

    public override void Awake(GameObject go)
    {
        tg_latch_open = this.transform.Find("bg_left/tg_latch_open").GetComponent<Toggle>();
        tg_snubber_raise = this.transform.Find("bg_left/tg_snubber_raise").GetComponent<Toggle>();
        tg_drum_and_lamp2 = this.transform.Find("bg_right_1/Toggle1").GetComponent<Toggle>();
        tg_sheave_and_lamp4 = this.transform.Find("bg_right_2/Toggle1").GetComponent<Toggle>();
        tg_sheave_and_lamp4.onValueChanged.AddListener((bool a)=> { OnSheaveAndLamp4(a); });
        tg_drum_and_lamp2.onValueChanged.AddListener((bool a) => { OnDrumAndLamp2(a); });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS Main Control1"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }

   void OnDrumAndLamp2(bool isOn) {
        tg_drum_and_lamp2.isOn = isOn;
        Slider sd_Drum = this.transform.Find("bg_right_1/ruler1/Slider").GetComponent<Slider>();
        sd_Drum.normalizedValue = isOn ? 1f : 0f;
        Slider sd_Lamp2 = this.transform.Find("bg_right_1/ruler2/Slider").GetComponent<Slider>();
        sd_Lamp2.normalizedValue = isOn ? 1f : 0f;
    }
    void OnSheaveAndLamp4(bool isOn)
    {
        tg_sheave_and_lamp4.isOn = isOn;
        Slider sd_Sheave = this.transform.Find("bg_right_2/ruler1/Slider").GetComponent<Slider>();
        sd_Sheave.normalizedValue = isOn ? 1f : 0f;
        Slider sd_Lamp4 = this.transform.Find("bg_right_2/ruler2/Slider").GetComponent<Slider>();
        sd_Lamp4.normalizedValue = isOn ? 1f : 0f;
    }

   
}