using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public static List<TooltipModel> tooltipModels = new List<TooltipModel>();

    [SerializeField]
    private TooltipUI tooltipUI;//提示窗口

    private void Start()
    {
        //调用
        //TooltipManager.tooltipModels.Add(new TooltipModel("警告：请先开始其他操作s警告：请先开始其他操作", 5f, Test));
    }

    void Update()
    {
        if (tooltipModels.Count > 0)
        {
            //qu
            TooltipModel tooltipModel = tooltipModels[0];
            tooltipModels.RemoveAt(0);
            tooltipUI.Active(tooltipModel);
        }
    }
    void Test()
    {
        Debug.Log("dosonething");
    }
}
