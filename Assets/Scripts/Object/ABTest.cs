using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ABTest : MonoBehaviour
{
    string path = @"E:\Unity Project\Company\HUN\VR-Submarine-Simulation-System-master\AssetBundles\StandaloneWindows64\vr_mainscene.scene";

    //指的你打包场景的名称
    public string sceneName = "AssetBundle";

    private void Start()
    {
        OnLoadABScene();


    }

    public void OnLoadABScene()
    {
        StartCoroutine(LoadFromFileAsync());//包体54.1M
        //SceneManager.LoadSceneAsync(1);//包体234M
    }

    /// <summary>
    /// 从本地中异步加载
    /// </summary>
    IEnumerator LoadFromFileAsync()
    {
        AssetBundleCreateRequest requst = AssetBundle.LoadFromFileAsync(path);
        yield return requst;
        AssetBundle ab = requst.assetBundle;
        SceneManager.LoadSceneAsync(sceneName);
    }
}

