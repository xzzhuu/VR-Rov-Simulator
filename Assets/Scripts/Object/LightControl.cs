using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
     List<GameObject> lamp_port_STBD=new List<GameObject>(2);
     List<GameObject> lamp_bullet_PT=new List<GameObject>(2);
     List<GameObject> lamp_bottom_PT=new List<GameObject>(3);
     Light light_bullet;
     Light light_pt;
     Light light_pt_bottom;
     Light light_port;
     Light light_STBD;
    void Start()
    {
     GameObject  ROV = this.gameObject.transform.Find(PathData.ROV).gameObject;
        light_bullet = ROV.transform.Find(PathData.LIGHT_BULLET).gameObject.GetComponent<Light>();
        light_pt = ROV.transform.Find(PathData.LIGHT_PT).gameObject.GetComponent<Light>();
        light_pt_bottom = ROV.transform.Find(PathData.LIGHT_PT_BOTTOM).gameObject.GetComponent<Light>();
        light_port = ROV.transform.Find(PathData.LIGHT_PORT).gameObject.GetComponent<Light>();
        light_STBD = ROV.transform.Find(PathData.LIGHT_STBD).gameObject.GetComponent<Light>();

        lamp_port_STBD.Add(ROV.transform.Find(PathData.LAMP_PORT_STBD_1).gameObject);
        lamp_port_STBD.Add(ROV.transform.Find(PathData.LAMP_PORT_STBD_2).gameObject);

        lamp_bullet_PT.Add(ROV.transform.Find(PathData.LAMP_BUTTET_PT_1).gameObject);
        lamp_bullet_PT.Add(ROV.transform.Find(PathData.LAMP_BUTTET_PT_2).gameObject);

        lamp_bottom_PT.Add(ROV.transform.Find(PathData.LAMP_BOTTOM_PT_1).gameObject);
        lamp_bottom_PT.Add(ROV.transform.Find(PathData.LAMP_BOTTOM_PT_2).gameObject);
        lamp_bottom_PT.Add(ROV.transform.Find(PathData.LAMP_BOTTOM_PT_3).gameObject);

        light_port.gameObject.SetActive(false);
        light_STBD.gameObject.SetActive(false);
        light_bullet.gameObject.SetActive(false);
        light_pt.gameObject.SetActive(false);
        light_pt_bottom.gameObject.SetActive(false);
    }

    /// <summary>
    /// ROV 光源控制脚本
    /// </summary>
    /// <param name="showPortSTBD"></param>
    /// <param name="showBulletPT"></param>
    /// <param name="showBottomPT"></param>
    /// <param name="showAll"></param>
   public void LampControl(bool showPortSTBD, bool showBulletPT, bool showBottomPT, bool showAll)
    {
        light_port.gameObject.SetActive (showPortSTBD || showAll);
        light_STBD.gameObject.SetActive(showPortSTBD || showAll);
        light_bullet.gameObject.SetActive(showBulletPT || showAll);
        light_pt.gameObject.SetActive(showBulletPT || showAll);
        light_pt_bottom.gameObject.SetActive(showBottomPT || showAll);
        for (int i = 0; i < lamp_port_STBD.Count; i++)
        {
            if (showPortSTBD || showAll)
                lamp_port_STBD[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            else
                lamp_port_STBD[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        }

        for (int i = 0; i < lamp_bullet_PT.Count; i++)
        {

            if (showBulletPT || showAll)
                lamp_bullet_PT[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            else
                lamp_bullet_PT[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        }

        for (int i = 0; i < lamp_bottom_PT.Count; i++)
        {

            if (showBottomPT || showAll)
                lamp_bottom_PT[i].gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            else
                lamp_bottom_PT[i].gameObject.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        }
    }

}
