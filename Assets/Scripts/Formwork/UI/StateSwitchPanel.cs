using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 用于切换按键的ROV操作功能
/// </summary>
public class StateSwitchPanel : MonoBehaviour
{
    [Header("手柄按键输入模块切换")]
    public Toggle Toggle_None;
    public Toggle Toggle_ROV;
    public Toggle Toggle_Gripper;

    public Button Btn_Return;
    public Text text;


    void Start()
    {
        text.text = "";
        Toggle_None.onValueChanged.AddListener(OnSelectNone);
        Toggle_ROV.onValueChanged.AddListener(OnSelectROV);
        Toggle_Gripper.onValueChanged.AddListener(OnSelectGripper);
        Btn_Return.onClick.AddListener(() => { HandUIMgr.Instance.OpenUIPanel(0); });
        EventTriggerListener.Get(Toggle_None.gameObject).onEnter = OnButtonEnter;
        EventTriggerListener.Get(Toggle_ROV.gameObject).onEnter = OnButtonEnter;
        EventTriggerListener.Get(Toggle_Gripper.gameObject).onEnter = OnButtonEnter;
        EventTriggerListener.Get(Toggle_None.gameObject).onExit = OnButtonExit;
        EventTriggerListener.Get(Toggle_ROV.gameObject).onExit = OnButtonExit;
        EventTriggerListener.Get(Toggle_Gripper.gameObject).onExit = OnButtonExit;

    }
    //None
    public void OnSelectNone(bool a)
    {
        OVRBtnInputMgr.Instance.OnButtonInput = false;
    }
    //ROV
    public void OnSelectROV(bool a)
    {
        OVRBtnInputMgr.Instance.OnButtonInput = true;
        HandUIMgr.Instance.inputMode = InputMode.ROV;
    }

    //Gripper
    public void OnSelectGripper(bool a)
    {
        OVRBtnInputMgr.Instance.OnButtonInput = true;
        HandUIMgr.Instance.inputMode = InputMode.Gripper;
    }

    private void OnButtonEnter(GameObject go)
    {
        //在这里监听按钮的点击事件
        if (go == Toggle_None.gameObject)
        {
            text.text = "选择此选项将禁用手柄对ROV和Gripper的操作";
        }
        if (go == Toggle_ROV.gameObject)
        {
            text.text = "选择此选项将启用手柄对ROV的操作";
        }
        if (go == Toggle_Gripper.gameObject)
        {
            text.text = "选择此选项将启用手柄对Gripper的操作";
        }
    }
    private void OnButtonExit(GameObject go)
    {
        text.text = "";

    }
}

