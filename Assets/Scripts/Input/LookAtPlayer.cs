//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-08-28 11:31:12
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：设置UI始终朝向玩家
//
//===================================================

using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
 
    public Transform eyeCameraTrans;
    public Transform root;

    public float distance=0.5f;
    public float height = 0.2f;

    public bool isShow=false;

    public GameObject Canvas_ConsoleDeskUI;
    public GameObject Canvas_StateUI;
  
    void Start()
    {
        Canvas_ConsoleDeskUI.gameObject.SetActive(false);
        Canvas_StateUI.gameObject.SetActive(false);
        eyeCameraTrans = Camera.main.transform;
        root = this.GetComponent<Transform>();
        FaceToPlayer(distance, height);
        OVRButtonInput.Instance.OVR_LIndexTriggerPress += ActiveUI;
    }

    /// <summary>
    /// 显示与隐藏设置UI面板
    /// </summary>
    void ActiveUI()
    {
        isShow = !isShow;
        if (isShow)
        {
           if (Canvas_ConsoleDeskUI.gameObject.activeSelf == false|| Canvas_StateUI.gameObject.activeSelf==false)
            {
                Canvas_ConsoleDeskUI.gameObject.SetActive(true);
                Canvas_StateUI.gameObject.SetActive(true);
            }
           
            FaceToPlayer(distance,height);
        }
        else
        {
            Canvas_ConsoleDeskUI.gameObject.SetActive(false);
            Canvas_StateUI.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// UI面板始终面向玩家
    /// </summary>
    void FaceToPlayer(float distance,float height)
    {
        root.position = eyeCameraTrans.position + eyeCameraTrans.forward * distance + eyeCameraTrans.up * height;
        Quaternion qua = eyeCameraTrans.rotation;
        qua.x = 0f;
        qua.z = 0f;
        root.rotation = qua;
    }
}
