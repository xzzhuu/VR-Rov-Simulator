﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIROVControls : UIPage
{
    private ArmControl armCtl = null;
   
    public UIROVControls() : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UIPrefab/UIROV Controls";
    }

    public override void Awake(GameObject go)
    {
        armCtl = GameObject.FindObjectOfType<ArmControl>();
        this.transform.Find("bg_left/Arm/btn_arrow_TurnOut").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.OpenCloseGripper(ARMDIR.Out);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnIn").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.OpenCloseGripper(ARMDIR.Out);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnL").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.RotateGripper(ARMDIR.TurnL);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnR").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.RotateGripper(ARMDIR.TurnR);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnLong").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.StretchArm(ARMDIR.Long); ;
        });
        this.transform.Find("bg_left/Arm/btn_arrow_TurnShort").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.StretchArm(ARMDIR.Short);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Up").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.MoveArm(ARMDIR.Up);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Down").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.MoveArm(ARMDIR.Down);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Left").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.MoveArm(ARMDIR.Left);
        });
        this.transform.Find("bg_left/Arm/btn_arrow_Right").GetComponent<ButtonEX>().onPress.AddListener(() =>
        {
            armCtl.MoveArm(ARMDIR.Right);
        });
    
    }

    public override void Active()
    {
        base.Active();
        MsgMng.Instance.Send(MessageName.MSG_CHANGE_TITTLE, new MessageData("ROV Controls"));
        MsgMng.Instance.Send(MessageName.MSG_SHOW_BTN_BACK, new MessageData(true));
    }
}
