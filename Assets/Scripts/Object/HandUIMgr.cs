using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum InputMode
{
    ROV,
    Gripper
}
public class HandUIMgr : MonoSingleton<HandUIMgr>
{
    private InputMode inputMode;
    public InputMode InputMode { get => inputMode; set => inputMode = value; }

    LookAtPlayer lookAtPlayer;

  public  GameObject[] UIPanels;
  
    void Start()
    {
        OpenUIPanel(0);

        OVRBtnInputMgr.Instance.OVR_LHandTriggerPress += ActivateUI;//左手柄HandTrigger按键开关UI菜单
        lookAtPlayer = this.GetComponent<LookAtPlayer>();
    }


    bool isShow = false;
    void ActivateUI()
    {
        isShow = !isShow;
        if (isShow)
        {
            lookAtPlayer.FaceToPlayer();
        }
        else
        {

        }
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


    /// <summary>
    /// 打开特定的UI面板
    /// </summary>
    /// <param name="index">UI面板索引</param>
    public void OpenUIPanel(int index)
    {
        if (UIPanels.Length == 0) return;
            foreach (GameObject obj in UIPanels)
            {
                if (obj == UIPanels[index])
                {
                    obj.gameObject.SetActive(true);
                }
                else
                {
                    obj.gameObject.SetActive(false);
                }
            }
    }
    
}
