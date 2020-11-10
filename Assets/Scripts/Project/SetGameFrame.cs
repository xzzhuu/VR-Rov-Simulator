//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-08-26 08:57:46
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：1.锁定应用的帧率（72HZ）
//            2.XR参数的设置
//            3.整个项目只需要调用此脚本一次（开始场景）
//===================================================
using UnityEngine;
using UnityEngine.XR;

public class SetGameFrame : MonoBehaviour
{
    public  int targetFrameRate = 72;//固定帧率

    void Awake()
    {
#if UNITY_EDITOR
        Debug.Log("在编辑器中");
#elif UNITY_ANDROID
        QualitySettings.vSyncCount = 0;
        QualitySettings.lodBias = 2;
        Application.targetFrameRate = targetFrameRate;
        XRSettings.eyeTextureResolutionScale = 1.4f;
#else 
         QualitySettings.vSyncCount = 0;
        QualitySettings.lodBias = 2;
#endif
    }
}
