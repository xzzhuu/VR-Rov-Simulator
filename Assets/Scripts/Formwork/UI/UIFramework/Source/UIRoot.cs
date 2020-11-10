﻿
   using System.Collections;
   using UnityEngine.EventSystems;
   using UnityEngine.UI;
   using UnityEngine;

   public class UIRoot : MonoBehaviour {

    public static UIRoot Instance;

    [Header("--控制台UI面板节点(Canvas-ConsoleDesk)")]
    public Transform fixedRoot;
    public Transform normalRoot;
    public Transform popupRoot;


    [Header("--ROV-数据显示视图")]
    public Transform ROV_DataDisplayRoot;

  
    void Awake()
    {
        Instance = this;
    }

     void Start()
    {
        UIPage.ShowPage<UITopBar>();//初始化，打开控制台的UI面板（Canvas-ConsoleDesk ）
        UIPage.ShowPage<UIOperational>();
       // UIPage.ShowPage<UIEnviroment>();
    }


}
