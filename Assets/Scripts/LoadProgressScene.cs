using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadProgressScene : MonoBehaviour
{
    // string path = 
    string path = "";
    //StreamingAssets文件夹下

    //指的你打包场景的名称
    public string sceneName = "VR_MainScene";
    AsyncOperation async;
    public Image loadProgressIma;//进度条图片
    float culload = 0f;//已加载的进度
    public Text loadText;//显示文本

    void Start()
    {
        path =
#if UNITY_EDITOR
     @"E:\Unity Project\VR-Mobile-Submarine-Simulation-System\AssetBundles\StandaloneWindows64\vr_mainscene.scene";
#else
    Application.streamingAssetsPath + "/vr_mainscene.scene";
#endif     
        loadText.text = "";
        StartCoroutine(nameof(LoadScene));

    }
    //定义一个迭代器，每一帧返回一次当前的载入进度，同时关闭自动的场景跳转
    //因为LoadScenceAsync每帧加载一部分游戏资源，每次返回一个有跨越幅度的progress进度值
    //当游戏资源加载完毕后，LoadScenceAsync会自动跳转场景，所以并不会显示进度条达到了100%
    //关闭自动场景跳转后，LoadSceneAsync只能加载90%的场景资源，剩下的10%场景资源要在开启自动场景跳转后才加载
    IEnumerator LoadScene()
    {
        AssetBundleCreateRequest requst = AssetBundle.LoadFromFileAsync(path);
        yield return requst;
        AssetBundle ab = requst.assetBundle;
        async = SceneManager.LoadSceneAsync(sceneName);
        // async = SceneManager.LoadSceneAsync("MainScene");
        async.allowSceneActivation = false;
        yield return async;
    }
    void Update()
    {
        if (async == null)
        {
            return;
        }
        int progressValue = 0;
        //当场景加载进度在90%以下时，将数值以整数百分制呈现，当资源加载到90%时就将百分制进度设置为100
        if (async.progress < 0.9f)
        {
            progressValue = (int)async.progress * 100;
        }
        else
        {
            progressValue = 100;
        }
        if (culload < progressValue)
        {
            culload++;
            loadProgressIma.fillAmount = culload * 0.01f;
            loadText.text = culload.ToString() + "%";
            //  slider.value = culload *0.01f;
        }
        //一旦进度到达100时，开启自动场景跳转，LoadSceneAsync会加载完剩下的10%的场景资源
        if (culload == 100)
        {
            loadText.text = "加载完成";
            async.allowSceneActivation = true;
        }
    }

}
