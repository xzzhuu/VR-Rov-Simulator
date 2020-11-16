using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 手柄UI，总功能模块控制菜单
/// </summary>
public class MainMenuPanel : PanelBase
{
    public Button Btn_ConsoleDesk;
    public Button Btn_DataView;
    public Button Btn_OperationSwitch;
    public Button Btn_System;
    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "MainMenuPanel";
        layer = PanelLayer.Panel;
    }
    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;

    }

    void SetOffBtnPos(RectTransform rect)
    {

    }
}
