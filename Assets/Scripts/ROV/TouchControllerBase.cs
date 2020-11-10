//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-09-04 13:59:38
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：
//          控制器组合键功能逻辑切换
//===================================================
using UnityEngine;

public class TouchControllerBase : MonoBehaviour
{
    protected RobotControl robotControl;
    protected TMSRopeControl tmsRopeControl;

    protected virtual void Awake()
    {
        robotControl = GameObject.FindGameObjectWithTag(Tag.ROV).GetComponent<RobotControl>();
        tmsRopeControl = GameObject.FindGameObjectWithTag(Tag.ROV).GetComponent<TMSRopeControl>();
    }

    protected virtual void Start()
    {
    }
}

