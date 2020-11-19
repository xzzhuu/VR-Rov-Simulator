using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIDataViewPanel : MonoBehaviour
{
    public GameObject View1UI;
    public GameObject View2UI;
   public Toggle tg_View1;
   public Toggle tg_View2;

    public Button Btn_Return;
    public Text text;
    void Start()
    {
        text.text = "";
        tg_View1.onValueChanged.AddListener(OnViewToggle);
        tg_View2.onValueChanged.AddListener(OnViewToggle);
        Btn_Return.onClick.AddListener(() => { HandUIMgr.Instance.OpenUIPanel(0); });
        EventTriggerListener.Get(tg_View1.gameObject).onEnter = OnButtonEnter;
        EventTriggerListener.Get(tg_View2.gameObject).onEnter = OnButtonEnter;
        EventTriggerListener.Get(tg_View1.gameObject).onExit = OnButtonExit;
        EventTriggerListener.Get(tg_View2.gameObject).onExit = OnButtonExit;
    }

  void OnViewToggle(bool a)
    {
        if (tg_View1.isOn) View1UI.gameObject.SetActive(true);
        if (tg_View2.isOn) View2UI.gameObject.SetActive(true);
    }

    private void OnButtonEnter(GameObject go)
    {
        //在这里监听按钮的点击事件
        if (go == tg_View1.gameObject)
        {
            text.text = "大屏显示[图表-1]数据状态";
        }
        if(go== tg_View2.gameObject)
        {
            text.text = "大屏显示[图表-2]数据状态";
        }
    }
    private void OnButtonExit(GameObject go)
    {
      text.text = "";
      
    }
}
