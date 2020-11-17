using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UITopBar : UIPage {

   // private static UITopBar instance;
   // public static UITopBar getInstance() { 
    // return instance;
   // }

    Action<MessageData> callback_Show;
    GameObject btnBack;
    public UITopBar() : base(UIType.Fixed, UIMode.DoNothing)
    {
        uiPath = "UIPrefab/UITopbar";
    }

    public override void Awake(GameObject go)
    {
        btnBack = this.gameObject.transform.Find("btn_back").gameObject;
        btnBack.GetComponent<Button>().onClick.AddListener(() => { UIPage.ClosePage(); });

        this.gameObject.transform.Find("TagMenu/tg_Start Menu").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UIStartMenu>(); } });
        this.gameObject.transform.Find("TagMenu/tg_ROV Menu").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UIROVMenu>(); } });
        this.gameObject.transform.Find("TagMenu/tg_Main Screens").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UIMainScreens>(); btnBack.SetActive(false); } });
        this.gameObject.transform.Find("TagMenu/tg_TMS Displays").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UITMSDisplays>(); btnBack.SetActive(false); } });
        this.gameObject.transform.Find("TagMenu/tg_TMS Menu").GetComponent<Toggle>().onValueChanged.AddListener((bool isOn) => { if (isOn) { UIPage.ShowPage<UITMSMenu>(); btnBack.SetActive(false); } });
    }


    void SetBackBtn(MessageData data)
    {
        btnBack.SetActive(data.valueBool);
    }
    void SetTitle(MessageData data)
    {
        this.gameObject.transform.Find("txt_Tittle").GetComponent<Text>().text = data.valueString;
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Register(MessageName.MSG_CHANGE_TITTLE, SetTitle);
        MsgMng.Instance.Register(MessageName.MSG_SHOW_BTN_BACK, SetBackBtn);
    }

    public override void Hide()
    {
        base.Hide();
        MsgMng.Instance.Remove(MessageName.MSG_CHANGE_TITTLE, SetTitle);
    }

}
