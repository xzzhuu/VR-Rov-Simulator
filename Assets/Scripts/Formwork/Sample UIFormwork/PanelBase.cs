using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//面板基类
public class PanelBase : MonoBehaviour
{
    //皮肤路径
    public string skinPath;
    /// <summary>
    /// 面板对象
    /// </summary>
    public GameObject skin;
    //层级
    public PanelLayer layer;
    //面板参数
    public object[] args;

    #region 生命周期
    //初始化
    public virtual void Init(params object[] args)
    {
        this.args = args;
    }
    //开始面板前
    public virtual void OnShowing() { }
    //显示面板后
    public virtual void OnShowed() { }
    //帧更新
    public virtual void Update() { }
    //关闭前
    public virtual void OnClosing() { }
    //关闭后
    public virtual void OnClosed() { }
    #endregion

    #region 操作
    /// <summary>
    /// 激活面板
    /// </summary>
    protected virtual void Active()
    {
        string name = this.GetType().ToString();
        PanelMgr.Instance.ActivePanel(name);
    }
    /// <summary>
    /// 隐藏面板
    /// </summary>
    protected virtual void Disable()
    {
        string name = this.GetType().ToString();
        PanelMgr.Instance.DisablePanel(name);
    }
    /// <summary>
    /// 关闭面板
    /// </summary>
    protected virtual void Close()
    {
        string name = this.GetType().ToString();
        PanelMgr.Instance.ClosePanel(name);
    }

    void Close(string name)
    {
        PanelMgr.Instance.ClosePanel(name);
    }

    public virtual void Close(float t)
    {
        Invoke("Close", t);
    }

    #endregion
}

