using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform TargetTrans; // 移动的物体
    Vector3 deviation; // 偏移量

    void Start()
    {
        TargetTrans = GameObject.Find("RobotControl/ROV3").transform;
        // 初始物体与相机的偏移量=相机的位置 - 移动物体的偏移量
       deviation = transform.position - TargetTrans.position; 
    }
    bool isFollow = false;
    void Update()
    {
        //因为屏幕看起来就像是二维坐标一样,所以要将游戏物体的世界坐标转化为游戏屏幕的二维坐标
        Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
        if (IsInView(TargetTrans.position))
        {
            Debug.Log("目前目标物体在摄像机范围内");
            isFollow = false;
        }
        else
        {
            Debug.Log("目前目标物体不在摄像机范围内");
            // Vector2 vec2 = Camera.main.WorldToScreenPoint(this.gameObject.transform.position);
            //  transform.position = TargetTrans.position + deviation;
            isFollow = true;
        }
    }

    private void LateUpdate()
    {
        if (isFollow)
        {
            transform.position = TargetTrans.position + deviation;
        }
        // 相机的位置 = 移动物体的位置 + 偏移量
       // transform.position = TargetTrans.position + deviation; 
    }

    public bool IsInView(Vector3 worldPos)
    {
        //获得游戏场景中主摄像机的Transfrom引用
        Transform camTransform =this.GetComponent<Camera>().transform;
        //将传过来的世界坐标转化为游戏屏幕坐标
        Vector2 viewPos = this.GetComponent<Camera>().WorldToViewportPoint(worldPos);
        //将坐标进行规范化
        Vector3 dir = (worldPos - camTransform.position).normalized;
        //判断物体是否在相机前面
        float dot = Vector3.Dot(camTransform.forward, dir);


        if (dot > 0 && viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1)
            return true;
        else
            return false;
    }


}
