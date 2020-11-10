//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-09-04 10:44:07
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：
//          雷达扫描效果（伪）
//
//===================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarScanning : MonoBehaviour
{
    public float speed = 5f;
    int count = 0;
    public GameObject ScanTargets;
    public GameObject Needle;//指针
    List<GameObject> targetList = new List<GameObject>();

    void Start()
    {
    
        for (int i = 0; i < ScanTargets.transform.childCount; i++)
        {
            var child = ScanTargets.transform.GetChild(i).gameObject;
            targetList.Add(child);
            //Debug.Log(child.name);
        }
       for(int i = 0; i < targetList.Count; i++)
        {
            targetList[i].gameObject.SetActive(false);
        }
    }


    void Update()
    {
        if (count == 5)
            targetList[0].gameObject.SetActive(true);

        if (count == 200)
            targetList[1].gameObject.SetActive(true);

        if (count == 500)
            targetList[2].gameObject.SetActive(true);

        if (count == 1000)
            targetList[3].gameObject.SetActive(true);

        count++;

        //指针旋转
        Needle.transform.Rotate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        if (Needle.transform.localEulerAngles.x != 0f)
        {
            Needle.transform.localEulerAngles = new Vector3(0f, 0f, Needle.transform.localEulerAngles.z);
        }

    }

}
