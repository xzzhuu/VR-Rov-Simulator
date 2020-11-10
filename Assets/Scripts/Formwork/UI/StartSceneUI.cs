using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

/// <summary>
/// 开始场景UI
/// </summary>
public class StartSceneUI : MonoBehaviour
{
    Button StartGameBtn;
     Button ExitBtn;

    void Start()
    {
        StartGameBtn = transform.Find("StartGameBtn").GetComponent<Button>();
        ExitBtn = transform.Find("ExitBtn").GetComponent<Button>();
        StartGameBtn.onClick.AddListener(OnStartGameClick);
        ExitBtn.onClick.AddListener(OnExitClick);
    }

    /// <summary>
    /// 开始应用按钮事件
    /// </summary>
    public void OnStartGameClick()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// 退出应用按钮事件
    /// </summary>
    public void OnExitClick()
    {
# if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
