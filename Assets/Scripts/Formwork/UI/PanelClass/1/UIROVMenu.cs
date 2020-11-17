using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIROVMenu : UIPage
{

    public UIROVMenu() : base(UIType.Normal, UIMode.HideOther)
    {
        uiPath = "UIPrefab/UIROVMenu";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("Btns/btn_System Start").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISystemStart>();
        });
        this.transform.Find("Btns/btn_Main Control1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIMainControl1>();
        });
        this.transform.Find("Btns/btn_Main Control2").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIMainControl2>();
        });
        this.transform.Find("Btns/btn_Pilot Flight").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIPilotFightScreen>();
        });
        this.transform.Find("Btns/btn_ROV Desk").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROVDesk>();
        });
        this.transform.Find("Btns/btn_HCU 1").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIHCU1>();
        });
        this.transform.Find("Btns/btn_Survey").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISurvey>();
        });
        this.transform.Find("Btns/btn_Camera Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UICameraControl>();
        });
        this.transform.Find("Btns/btn_Roll Trim").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIRollTrim>();
        });
        this.transform.Find("Btns/btn_Power Resets").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIPowerResets>();
        });
        this.transform.Find("Btns/btn_Cleaning Screen").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UICleaningScreen>();
        });
        this.transform.Find("Btns/btn_HCU 2 HI Flow").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIHCU2HiFlow>();
        });
        this.transform.Find("Btns/btn_ROV Controls").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROVControls>();
        });
        //this.transform.Find("Btns/btn_Port Manipulator").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIPortManipulatorControls>();
        //});
        //btn_ROV_Pressurize
        this.transform.Find("Btns/btn_ROV_Pressurize").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIROV_Pressurize>();
        });
        this.transform.Find("Btns/btn_Lamp Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UILampControls>();
        });
        
        this.transform.Find("Btns/btn_Auxiliary Port Control").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIAuxilliaryPortControl>();
        });
        this.transform.Find("Btns/btn_Auto Position").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIAutoPositioning>();
        });
        this.transform.Find("Btns/btn_Auto Pitch_Roll").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIAutoPitch_Roll>();
        });
        this.transform.Find("Btns/btn_Auto Speed_Tracking").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIAutoSpeed_Tracking>();
        }); 
        this.transform.Find("Btns/btn_Quick Function").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIQuickFunctionConfiguration> ();
        }); 
    }
    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Menu"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
    }

   
}