using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITMSMenu : UIPage
{

    public UITMSMenu() : base(UIType.Normal, UIMode.HideOther)
    {
        uiPath = "UIPrefab/UITMS Menu";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("btn_TMS Main Control1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UITMSMainControl1>();
        });
        this.transform.Find("btn_TMS Desk Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UITMSDesk>();
        });
        this.transform.Find("btn_Mobilisation").GetComponent<Button>().onClick.AddListener(() =>
        {
           UIPage.ShowPage<UIMobilisation>();
        });
        this.transform.Find("btn_Camera Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UICameraControl>();
        });
        this.transform.Find("btn_Lamp Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UILampControls>();
        });
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("TMS Menu"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
    }
}
