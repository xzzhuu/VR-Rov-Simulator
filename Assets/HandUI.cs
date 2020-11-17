using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum InputMode
{
    ROV,
    Gripper
}
public class HandUI : MonoSingleton<HandUI>
{
    public InputMode inputMode { get; set; }
    public override void Awake()
    {
        //base.Awake();
    }
    void Start()
    {
        ROVStateData.GetInstance().CompleteTotalSettingEvent += CompleteRovSetting;
        ROVStateData.GetInstance().UncompleteTotalSettingEvent += UncompleteRovSetting;
    }

    /// <summary>
    /// 当满足ROV操作条件时初始化手柄功能控件  按键点击
    /// </summary>
     void CompleteRovSetting()
    {

    }
     void UncompleteRovSetting()
    {

    }
}
