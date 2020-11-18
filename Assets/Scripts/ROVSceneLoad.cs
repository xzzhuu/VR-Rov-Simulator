using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ROVSceneLoad : MonoBehaviour
{
    [SerializeField]
    private Button Btn_Return;
    [SerializeField]
    private Button Btn_Restart;
    [SerializeField]
    private Button Btn_Exit;
    [SerializeField]
    private Text Txt_describe;
   

    void Start()
    {
        Txt_describe.text = "";
        Btn_Return.onClick.AddListener(OnReturn);
        Btn_Restart.onClick.AddListener(OnRestartScene);
        Btn_Exit.onClick.AddListener(OnExitScene);
        EventTriggerListener.Get(Btn_Return.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_Restart.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_Exit.gameObject).onEnter = OnEnterDoSomething;
        EventTriggerListener.Get(Btn_Return.gameObject).onExit = OnExitDoSomething;
        EventTriggerListener.Get(Btn_Restart.gameObject).onExit = OnExitDoSomething;
        EventTriggerListener.Get(Btn_Exit.gameObject).onExit = OnExitDoSomething;
    }
    void OnReturn()
    {
        HandUI.Instance.OpenUIPanel(0);
    }
    void OnRestartScene()
    {
        //load
        SceneManager.LoadScene(0);

    }
    void OnExitScene()
    {
        Application.Quit();
    }

    void OnEnterDoSomething(GameObject go)
    {
      
        //在这里监听按钮的点击事件
        if (go == Btn_Return.gameObject)
        {
           Txt_describe.text = "选择此选项将返回主菜单界面";
        }
        if (go == Btn_Restart.gameObject)
        {
            Txt_describe.text = "选择此选项将重新加载应用程序";
        }
        if (go == Btn_Exit.gameObject)
        {
            Txt_describe.text = "选择此选项将退出应用程序";
        }
    }

    void OnExitDoSomething(GameObject go)
    {
        Txt_describe.text = "";
    }

}
