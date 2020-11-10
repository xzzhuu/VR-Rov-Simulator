using UnityEngine;

public class UICamTextureControl : MonoBehaviour
{
    [Header("ROV镜头")]
    Camera Cam_RovFrontView;
    Camera Cam_RovTop;
    Camera Cam_PT;
    Camera Cam_PT_Bottom;

    public Material skyboxMat;

    void Awake()
    {
   
    }

    private void Start()
    {
        Cam_RovFrontView = transform.Find(PathData.CAM_ROVFRONTVIEW).GetComponent<Camera>();
        Cam_RovTop = transform.Find(PathData.CAM_ROVTOP).GetComponent<Camera>();
        Cam_PT = transform.Find(PathData.CAM_PT).GetComponent<Camera>();
        Cam_PT_Bottom = transform.Find(PathData.CAM_PT_BOTTOM).GetComponent<Camera>();
        TargetTextureSet();
      
    }
    void TargetTextureSet()
    {
        Cam_RovFrontView.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-RovFrontView");
        Cam_RovTop.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-RovTop");
        Cam_PT.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-PT");
        Cam_PT_Bottom.targetTexture = Resources.Load<RenderTexture>("CamRT/RT-PT-Bottom");
    }

    void SkyMaterialSet()
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
