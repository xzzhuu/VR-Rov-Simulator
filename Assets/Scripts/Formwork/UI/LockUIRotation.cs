using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 锁定UI面板预制体的旋转角度
/// </summary>
public class LockUIRotation : MonoBehaviour
{
    // Start is called before the first frame update
    RectTransform rectTransform;
    void Start()
    {
        rectTransform = this.GetComponent<RectTransform>();
    }

   
    void Update()
    {
        if (rectTransform.localEulerAngles.x != 0f || rectTransform.localEulerAngles.y != 0f|| rectTransform.localEulerAngles.z != 0f)
        {
            rectTransform.localEulerAngles = Vector3.zero;
        }
    }
}
