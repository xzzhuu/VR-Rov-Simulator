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
     Transform eyeCameraTrans;
     Transform root;

    public float distance=0.5f;
    public float height = 0.2f;

  
    void Start()
    {
        eyeCameraTrans = Camera.main.transform;
        root = this.GetComponent<Transform>();
       // FaceToPlayer(distance, height);
    }

    /// <summary>
    /// UI面板始终面向玩家
    /// </summary>
    public void FaceToPlayer(float distance=0.5f,float height=0.2f)
    {
        root.position = eyeCameraTrans.position + eyeCameraTrans.forward * distance + eyeCameraTrans.up * height;
        Quaternion qua = eyeCameraTrans.rotation;
        qua.x = 0f;
        qua.z = 0f;
        root.rotation = qua;
    }
}
