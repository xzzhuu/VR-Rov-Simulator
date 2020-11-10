using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainScreens :  UIPage
{

    public UIMainScreens() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIMainScreens";
    }

    public override void Awake(GameObject go)
    {
        this.transform.Find("btn_Operactional").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UIOperational>();
        });
  
        this.transform.Find("btn_System Status").GetComponent<Button>().onClick.AddListener(() =>
        {
            UIPage.ShowPage<UISystemStatus>();
        });

        //   this.transform.Find("btn_Flying").GetComponent<Button>().onClick.AddListener(() =>
        // {
        //    UIPage.ShowPage<UIFlying>();
        //  });
        //this.transform.Find("btn_Alarm Summary").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIAlarmSummary>();
        //});
        //this.transform.Find("btn_Deck Checks1").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_DeckChecks>();
        //});
        //this.transform.Find("btn_SubSea Power1").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_SubSeaPower>();
        //});
        //this.transform.Find("btn_Surface Power1").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_SurfacePower>();
        //});
        //this.transform.Find("btn_Comms1").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_Comms>();
        //});
        //this.transform.Find("btn_Vehicle Status2").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UITMS_VehicleStatus>();
        //});
        //this.transform.Find("btn_Vehicle Status1").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_VehicleStatus>();
        //});
        //this.transform.Find("btn_Deck Checks2").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UITMS_DeckChecks>();
        //});
        //this.transform.Find("btn_SubSea Power2").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UITMS_SubSeaPower>();
        //});
        //this.transform.Find("btn_Surface Power2").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UITMS_SurfacePower>();
        //});
        //this.transform.Find("btn_Comms2").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UITMS_Comms>();
        //});

        //this.transform.Find("btn_ROV Common").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_CommonInterlocks>();
        //});
        //this.transform.Find("btn_ROV Pod").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_PodPowerInteriocks>();
        //});
        //this.transform.Find("btn_ROV Motor").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_MotorInteriocks>();
        //});
        //this.transform.Find("btn_ROV Subsea").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_SubseaInteriocks>();
        //});
        //this.transform.Find("btn_Auto Heading").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_AutoHeadingInterlocks>();
        //});
        //this.transform.Find("btn_Auto Depth").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_AutoDepthInterlocks>();
        //});
        //this.transform.Find("btn_Auto Altutide").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_AutoAltitudeInterlocks>();
        //});
        //this.transform.Find("btn_Auto Position").GetComponent<Button>().onClick.AddListener(() =>
        //{
        //    UIPage.ShowPage<UIROV_AutoPositionInterlocks>();
        //});

    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("Main Screens"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(false));
    }
}
