using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//面板管理类
public class PanelMgr : MonoBehaviour
{
    public static PanelMgr Instance;

    private GameObject canvas;

    public Dictionary<string, PanelBase> dict;

    private Dictionary<PanelLayer, Transform> layerDict;

    public void Awake()
    {
        Instance = this;
        InitLayer();
        dict = new Dictionary<string, PanelBase>();
    }

    private void InitLayer()
    {
        //画布
        canvas = GameObject.Find("Canvas");
        if (canvas == null)
            Debug.LogError("panelMgr.InitLayer fail, canvas is null");
       
        //各个层级
        layerDict = new Dictionary<PanelLayer, Transform>();

        foreach (PanelLayer pl in Enum.GetValues(typeof(PanelLayer)))
        {
            string name = pl.ToString();
            Transform transform = canvas.transform.Find(name);
            layerDict.Add(pl, transform);
        }
    }

    /// <summary>
    /// 打开面板
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="skinPath"></param>
    /// <param name="args"></param>
    public void OpenPanel<T>(string skinPath, params object[] args) where T : PanelBase
    {
        //已经打开
        string panelName = typeof(T).ToString();
        if (dict.ContainsKey(panelName))
            return;
        //面板脚本
        PanelBase panel = canvas.AddComponent<T>();
        panel.Init(args);
        dict.Add(panelName, panel);

        //加载面板
        skinPath = (skinPath != "" ? skinPath : panel.skinPath);
        GameObject skin = Resources.Load<GameObject>(skinPath);
        if (skin == null)
            Debug.LogError("panelMgr.OpenPanel fail ,skin is null");
        panel.skin = (GameObject)Instantiate(skin);


        //坐标
        Transform skinTrans = panel.skin.transform;
        PanelLayer layer = panel.layer;
        Transform parent = layerDict[layer];
        skinTrans.SetParent(parent, false);
        //panel的生命周期
        panel.OnShowing();
        //anm
        panel.OnShowed();

    }

    //关闭面板
    public void ClosePanel(string name)
    {
        if (!dict.ContainsKey(name))
            return;
        PanelBase panel = (PanelBase)dict[name];
        if (panel == null)
            return;
        
        panel.OnClosing();
        dict.Remove(name);
        panel.OnClosed();
        GameObject.Destroy(panel.skin);
        Component.Destroy(panel);
    }

    /// <summary>
    /// 激活面板
    /// </summary>
    /// <param name="name"></param>
    public void ActivePanel(string name)
    {
        PanelBase panel = (PanelBase)dict[name];
        if (panel == null)
        {
            return;
        }
        panel.skin.SetActive(true);
    }

    /// <summary>
    /// 隐藏面板
    /// </summary>
    /// <param name="name"></param>
    public void DisablePanel(string name)
    {
        PanelBase panel = (PanelBase)dict[name];
        if (panel == null)
        {
            return;
        }
        panel.skin.SetActive(false);
    }
}

/// <summary>
/// 面板层
/// </summary>
public enum PanelLayer
{
    /// <summary>
    /// 面板
    /// </summary>
    Panel,
    /// <summary>
    /// 提示
    /// </summary>
    Tips,
}
