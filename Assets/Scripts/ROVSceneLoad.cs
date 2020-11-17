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
   
    private string currentActiveScene;

    void Start()
    {
        // currentActiveScene =  SceneManager.GetActiveScene().name;
        Btn_Return.onClick.AddListener(OnReturn);
        Btn_Restart.onClick.AddListener(OnRestartScene);
        Btn_Exit.onClick.AddListener(OnExitScene);
    }
    void OnReturn()
    {

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
