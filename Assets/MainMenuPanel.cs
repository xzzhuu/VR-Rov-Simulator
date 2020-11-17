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

    public GameObject ConsoleDeskUI;
    public GameObject DataViewUI;
    public GameObject OperationSwitchUI;
    public GameObject SystemUI;
    private void Start()
    {
        Btn_ConsoleDesk.onClick.AddListener(OnConsoleDeskBtnClick);
        Btn_DataView.onClick.AddListener(OnDataViewBtnClick);
        Btn_OperationSwitch.onClick.AddListener(OnOperationSwitchBtnClick);
        Btn_System.onClick.AddListener(OnSystemBtnClick);
    }


    void OnConsoleDeskBtnClick()
    {
        ConsoleDeskUI.gameObject.SetActive(true);
        DataViewUI.gameObject.SetActive(false);
        OperationSwitchUI.gameObject.SetActive(false);
        SystemUI.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    void OnDataViewBtnClick()
    {
        ConsoleDeskUI.gameObject.SetActive(false);
        DataViewUI.gameObject.SetActive(true);
        OperationSwitchUI.gameObject.SetActive(false);
        SystemUI.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    void OnOperationSwitchBtnClick()
    {
        ConsoleDeskUI.gameObject.SetActive(false);
        DataViewUI.gameObject.SetActive(false);
        OperationSwitchUI.gameObject.SetActive(true);
        SystemUI.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
    void OnSystemBtnClick()
    {
        ConsoleDeskUI.gameObject.SetActive(false);
        DataViewUI.gameObject.SetActive(false);
        OperationSwitchUI.gameObject.SetActive(false);
        SystemUI.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
