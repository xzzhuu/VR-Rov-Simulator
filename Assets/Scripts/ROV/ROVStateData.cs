using System.Collections;
using UnityEngine;
using System;

public delegate void CompleteTotalSettingHandle();
public delegate void UncompleteTotalSettingHandle();
public delegate bool CheckTotalSettingHandle();
public class ROVStateData
{
    private static readonly ROVStateData instance = new ROVStateData();
    public static ROVStateData GetInstance()
    {
        return instance;
    }
    public event CompleteTotalSettingHandle CompleteTotalSettingEvent;
    public event UncompleteTotalSettingHandle UncompleteTotalSettingEvent;
    public event CheckTotalSettingHandle CheckTotalSettingEvent;
    //ROV Desk界面参数设置是否完成
    public static bool SetF_ROVDesk1 { get; set; } = false;
    //Lamp Control界面参数设置是否完成
    public static bool SetF_LampControl { get; set; } = false;
    //TMS Main Control 界面参数设置是否完成
    public static bool SetF_TMSMainControl { get; set; } = false;
    //Main Control界面参数设置是否完成
    public static bool SetF_MainControl { get; set; } = false;

    string resultStr;
    /// <summary>
    /// 判断控制Rov之前的四个UI参数界面是否设置完成
    /// 设置完成即可用手柄控制ROV模型
    /// 否则手柄按键不能控制操作
    /// </summary>
    /// <returns></returns>
    public  bool IsFTotalControl()
    {
        OnCkeckTotalSetting();
        if (SetF_ROVDesk1 && SetF_LampControl && SetF_TMSMainControl && SetF_MainControl)
            return true;
        else
            return false;
    }

    public void OnCompleteTotalSetting()
    {
        if (this.CompleteTotalSettingEvent != null)
        {
            CompleteTotalSettingEvent();
        }
    }

    public void OnUncompleteTotalSetting()
    {
        if (this.UncompleteTotalSettingEvent != null)
        {
            UncompleteTotalSettingEvent();
        }
    }
    public void OnCkeckTotalSetting()
    {
        if (this.CheckTotalSettingEvent != null)
        {
            CheckTotalSettingEvent();
        }
    }
    string str1;
    string str2;
    string str3;
    string str4;
   public  string GetStateMessage()
    {
        if (IsFTotalControl())
        {
            resultStr = "设置已完成!请使用手柄进行ROV操作";
        }
        else
        {
            if (!SetF_ROVDesk1)
            {
                str1 = "ROV Desk界面参数设置未完成！";
            }
            else
            {
                str1 = "";
            }
            if (!SetF_LampControl)
            {
                str2 = "Lamp Control界面参数设置未完成！";
            }
            else
            {
                str2 = "";
            }
            if (!SetF_TMSMainControl)
            {
                str3 = "TMS Main Control 界面参数设置未完成！";
            }
            else
            {
                str3 = "";
            }
            if (!SetF_MainControl)
            {
                str4 = "Main Control界面参数设置未完成！";
            }
            else
            {
                str4 = "";
            }
            resultStr = "ROV参数未完成初始化设置：" + str1 + str2 + str3 + str4;
        }
        return resultStr;
    }
    

}
