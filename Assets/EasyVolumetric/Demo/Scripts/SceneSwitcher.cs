using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    private static SceneSwitcher instance;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Application.targetFrameRate = 60;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Update()
    {
        if (Input.anyKeyDown)
            NextScene();
    }

    private void NextScene()
    {
        int index = SceneManager.GetActiveScene().buildIndex;

        if (++index >= SceneManager.sceneCountInBuildSettings)
            index = 0;

        SceneManager.LoadScene(index);
    }

}
