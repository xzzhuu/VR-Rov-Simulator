using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILampControls : UIPage
{
   private LightControl lc;
    private Toggle tg1, tg2, tg3, tgAll;
    public UILampControls() : base(UIType.Normal, UIMode.HideOther)
    {
        uiPath = "UIPrefab/UILamp Controls";
    }

    public override void Awake(GameObject go)
    {
        lc = GameObject.FindObjectOfType<LightControl>();
        tg1 = transform.Find("rulers/bg1/Toggle1").GetComponent<Toggle>();
        tg2 = transform.Find("rulers/bg2/Toggle2").GetComponent<Toggle>();
        tg3 = transform.Find("rulers/bg3/Toggle3").GetComponent<Toggle>();
        tgAll = transform.Find("tg_All ROV Lamps").GetComponent<Toggle>();
        tgAll.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 4); });
        tg1.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 1); });
        tg2.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 2); });
        tg3.onValueChanged.AddListener((bool isOn) => { SetLamp(isOn, 3); });
        
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Lamp Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
    private void SetLamp(bool isOn, int type)
    {
       lc.LampControl(tg1.isOn, tg2.isOn, tg3.isOn, tgAll.isOn);
        if (type == 4)
        {
            for (int i = 1; i <= 6; i++)
            {
                Toggle tg = transform.Find(string.Format("rulers/bg{0}/Toggle{1}", i, i)).GetComponent<Toggle>();
                tg.isOn = isOn;
                for (int j = 1; j <= 2; j++)
                {
                    Slider sd = transform.Find(string.Format("rulers/bg{0}/ruler{1}/Slider", i, j)).GetComponent<Slider>();
                    sd.normalizedValue = isOn ? 1f : 0f;
                }
            }
        }
    }

}
