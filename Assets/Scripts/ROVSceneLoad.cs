using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ROVSceneLoad : MonoBehaviour
{
    private Button restartBtn;
    private Button exitBtn;

    private string currentActiveScene;

    void Start()
    {

       // currentActiveScene =  SceneManager.GetActiveScene().name;
        restartBtn = transform.Find("RestartSceneBtn").GetComponent<Button>();
        exitBtn = transform.Find("ExitSceneBtn").GetComponent<Button>();
        restartBtn.onClick.AddListener(OnRestartScene);
        exitBtn.onClick.AddListener(OnExitScene);
    }

    void OnRestartScene()
    {
        //load
    }
    void OnExitScene()
    {
        Application.Quit();
    }
   
}
