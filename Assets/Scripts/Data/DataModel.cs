using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//记录各个界面控件操作数据.
public class DataModel :Singleton<DataModel>
{
    public int curPT = 2;//当前操作云台 1--上方云台 2--下方云台.
    public float curDepth = 1000;//当前深度.
    public float curSpeed = 0.1f;//0.1m/s.

    //前后运动速度.
    public float GetSpeedSurge
    {
        get { return 0.55f; }
        set { }
    }
    //左右速度.
    public float GetSpeedSway
    {
        get { return 1.18f; }
        set { }
    }
    //上下速度.
    public float GetSpeedHeave
    {
        get { return 0f; }
        set { }
    }


    //前后Trim百分比.
    public float GetTrim_Fwd_Aft
    {
        get { return 45.5f; }
        set { }
    }

    //左右Trim百分比.
    public float GetTrim_Port_Stbd
    {
        get { return 45.5f; }
        set { }
    }

    //上下Trim百分比.
    public float GetTrim_UP_Down
    {
        get { return 28.1f; }
    }

    //右上螺旋桨百分比.
    public float GetPropRightUp
    {
        get { return 58.6f; }
    }


    //右下螺旋桨百分比.
    public float GetPropRightDown
    {
        get { return 58.6f; }
    }

    //左上螺旋桨百分比.
    public float GetPropLeftUp
    {
        get { return 58.6f; }
    }


    //左下螺旋桨百分比.
    public float GetPropLeftDown
    {
        get { return 58.6f; }
    }

    public float GetTMSUseLengh
    {
        get { return 0.0f; }
        set { }
    }


    public float TmsTotalLengh { get; set; } = 15f;
    public float TmsCurrentLengh { get; set; } =0f;
    public float CalTmsRopePercent()
    {
        return (TmsCurrentLengh / TmsTotalLengh)*100;
    }
    public float CalTmsCurrentLengh() {

        return TmsTotalLengh - TmsCurrentLengh;
    }
}
