using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OffButton : MonoBehaviour
{
    Button offBtn;

    public GameObject DesktopUI;
    void Start()
    {
        offBtn = this.transform.Find("Btn_OffPanel").GetComponent<Button>();
        offBtn.onClick.AddListener(OnOffBtnClick);
    }
    void OnOffBtnClick()
    {
        if (DesktopUI.gameObject.activeSelf)
            HandUIMgr.Instance.OpenUIPanel(0);

    }
   
}
