using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 手柄UI，总功能模块控制菜单
/// </summary>
public class MainMenuPanel : MonoBehaviour
{
    [SerializeField]
     Button Btn_ConsoleDesk;
    [SerializeField]
    Button Btn_DataView;
    [SerializeField]
    Button Btn_OperationSwitch;
    [SerializeField]
    Button Btn_System;
    [SerializeField]
    Text Txt_Describe;


    void Start()
    {
        Txt_Describe.text = "";
        Btn_ConsoleDesk.onClick.AddListener(()=> { OnOpenUIPanelClick(1); });
        Btn_DataView.onClick.AddListener(() => { OnOpenUIPanelClick(2); });
        Btn_OperationSwitch.onClick.AddListener(() => { OnOpenUIPanelClick(3); });
        Btn_System.onClick.AddListener(() => { OnOpenUIPanelClick(4); });

        EventTriggerListener.Get(Btn_ConsoleDesk.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_ConsoleDesk.gameObject).onExit = OnExitDoSomething;
        EventTriggerListener.Get(Btn_DataView.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_DataView.gameObject).onExit = OnExitDoSomething;
        EventTriggerListener.Get(Btn_OperationSwitch.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_OperationSwitch.gameObject).onExit = OnExitDoSomething;
        EventTriggerListener.Get(Btn_System.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_System.gameObject).onExit = OnExitDoSomething;
    }

    void OnOpenUIPanelClick(int indx)
    {
        HandUI.Instance.OpenUIPanel(indx);
    }
  
    void OnEnterDoSomething(GameObject go)
    {
        if (go == Btn_ConsoleDesk.gameObject)
        {
            Txt_Describe.text = "选择此选项将打开ROV操作参数设置界面";
        }
        if (go == Btn_DataView.gameObject)
        {
            Txt_Describe.text = "选择此选项将打开ROV状态数据图表类型切换界面";
        }
        if (go == Btn_OperationSwitch.gameObject)
        {
            Txt_Describe.text = "选择此选项将打开ROV手柄操作模式切换界面";
        }
        if (go == Btn_System.gameObject)
        {
            Txt_Describe.text = "选择此选项将打开应用设置界面";
        }
    }
    void OnExitDoSomething(GameObject go)
    {
        Txt_Describe.text = "";
    }
}
