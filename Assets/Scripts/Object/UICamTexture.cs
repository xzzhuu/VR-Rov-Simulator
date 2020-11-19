using UnityEngine;

public class UICamTexture : MonoBehaviour
{
    [Header("ROV镜头")]
    [SerializeField]
    Camera Cam_RovFrontView; //ROV整体摄像机
    [SerializeField]
    Camera Cam_RovTop;//ROV 顶部摄像机
    [SerializeField]
    Camera Cam_PT;    //ROV云台摄像机
    [SerializeField]
    Camera Cam_PT_Bottom; //ROV底部摄像机


    private void Start()
    {
        TargetTextureSet();
      
    }
    void TargetTextureSet()
    {
        Cam_RovFrontView.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-RovFrontView");
        Cam_RovTop.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-RovTop");
        Cam_PT.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-PT");
        Cam_PT_Bottom.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-PT-Bottom");
       
    }

    void SkyMaterialSet(Material skyboxMat)
    {
        Cam_RovFrontView.clearFlags = CameraClearFlags.Skybox;
        Cam_RovTop.clearFlags = CameraClearFlags.Skybox;
        Cam_PT.clearFlags = CameraClearFlags.Skybox;
        Cam_PT_Bottom.clearFlags = CameraClearFlags.Skybox;

        if (Cam_RovFrontView.gameObject.GetComponent<Skybox>() == null)
            Cam_RovFrontView.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_RovFrontView.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_RovTop.gameObject.GetComponent<Skybox>() == null)
            Cam_RovTop.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_RovTop.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_PT.gameObject.GetComponent<Skybox>() == null)
            Cam_PT.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_PT.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_PT_Bottom.gameObject.GetComponent<Skybox>() == null)
            Cam_PT_Bottom.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_PT_Bottom.gameObject.GetComponent<Skybox>().material = skyboxMat;
    }

}
