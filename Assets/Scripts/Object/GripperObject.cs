using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GripperObject : MonoBehaviour
{

    public  bool isLeftGripperAdsorb = false;//是否与左臂爪碰撞（吸附）
    public  bool isRightGripperAdsorb = false; //是否与右臂爪碰撞（吸附）
   
    void Start()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag(Tag.GRIPPER_LEFT))
        {
            isLeftGripperAdsorb = true;
        }
        if (collision.collider.CompareTag(Tag.GRIPPER_Right))
        {
            isRightGripperAdsorb = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag(Tag.GRIPPER_LEFT))
        {
            isLeftGripperAdsorb = false;
        }
        if (collision.collider.CompareTag(Tag.GRIPPER_Right))
        {
            isRightGripperAdsorb = false;
        }
    }

    /// <summary>
    /// 是否同时满足与左右机械爪碰撞
    /// </summary>
    /// <returns></returns>
    public bool isMatchGripper()
    {
        if (isLeftGripperAdsorb && isRightGripperAdsorb) return true;
        else return false;
        
    }
}
