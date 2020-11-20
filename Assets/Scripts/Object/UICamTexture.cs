using UnityEngine;

public class UICamTexture : MonoBehaviour
{
    [Header("ROV镜头")]
    [SerializeField]
    Camera Cam_Front; //ROV整体摄像机
    [SerializeField]
    Camera Cam_Top;//ROV 顶部摄像机
    [SerializeField]
    Camera Cam_PT;    //ROV云台摄像机
    [SerializeField]
    Camera Cam_Bottom; //ROV底部摄像机


    private void Start()
    {
        TargetTextureSet();
      
    }
    void TargetTextureSet()
    {
        Cam_Front.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-Front");
        Cam_Top.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-Top");
        Cam_PT.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-PT");
        Cam_Bottom.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-Bottom");
       
    }

    void SkyMaterialSet(Material skyboxMat)
    {
        Cam_Front.clearFlags = CameraClearFlags.Skybox;
        Cam_Top.clearFlags = CameraClearFlags.Skybox;
        Cam_PT.clearFlags = CameraClearFlags.Skybox;
        Cam_Bottom.clearFlags = CameraClearFlags.Skybox;

        if (Cam_Front.gameObject.GetComponent<Skybox>() == null)
            Cam_Front.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_Front.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_Top.gameObject.GetComponent<Skybox>() == null)
            Cam_Top.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_Top.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_PT.gameObject.GetComponent<Skybox>() == null)
            Cam_PT.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_PT.gameObject.GetComponent<Skybox>().material = skyboxMat;

        if (Cam_Bottom.gameObject.GetComponent<Skybox>() == null)
            Cam_Bottom.gameObject.AddComponent<Skybox>().material = skyboxMat;
        else Cam_Bottom.gameObject.GetComponent<Skybox>().material = skyboxMat;
    }

}
