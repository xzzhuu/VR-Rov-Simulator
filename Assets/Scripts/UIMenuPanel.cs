using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuPanel : MonoBehaviour
{
    public Button Btn_Right;
    public GameObject ROVDataDisplayView;
    public GameObject ConsoleDesk;
    public GameObject AnimationBtnCanvas;

    float targetHeight = 1.2f;
    GameObject MenuPanelObj;
    void Start()
    {
        AnimationBtnCanvas.gameObject.SetActive(false);
        Btn_Right.onClick.AddListener(RightPos);
        MenuPanelObj = transform.Find("MenuPanel").gameObject;
        //OVRButtonInput.Instance.OVR_LIndexTriggerPress += OnOffMenuPanel;
    }

    void Update()
    {
        if (ROVDataDisplayView.gameObject.activeSelf && ConsoleDesk.gameObject.activeSelf)
        {
            AnimationBtnCanvas.gameObject.SetActive(true);
        }
        else
        {
            AnimationBtnCanvas.gameObject.SetActive(false);
            return;
        }
        if (!isClick) return;
        if (isRight)
        {
            ROVDataDisplayView.transform.Translate(new Vector3(0, -1f, 0f) * Time.deltaTime * 5f);
            if (ROVDataDisplayView.transform.localPosition.y <= targetHeight)
            {
                ROVDataDisplayView.transform.localPosition = new Vector3(ROVDataDisplayView.transform.localPosition.x, targetHeight, ROVDataDisplayView.transform.localPosition.z);
            }
            ConsoleDesk.transform.Translate(new Vector3(0, 1f, 0f) * Time.deltaTime * 5f);
            if (ConsoleDesk.transform.localPosition.y >= targetHeight + 0.55f)
            {
                ConsoleDesk.transform.localPosition = new Vector3(ConsoleDesk.transform.localPosition.x, targetHeight + 0.55f, ConsoleDesk.transform.localPosition.z);
                isClick = false;
            }

        }
        else
        {

            ROVDataDisplayView.transform.Translate(new Vector3(0, 1f, 0f) * Time.deltaTime * 5f);
            if (ROVDataDisplayView.transform.localPosition.y >= targetHeight + 0.55f)
            {
                ROVDataDisplayView.transform.localPosition = new Vector3(ROVDataDisplayView.transform.localPosition.x, targetHeight + 0.55f, ROVDataDisplayView.transform.localPosition.z);
            }
            ConsoleDesk.transform.Translate(new Vector3(0, -1f, 0f) * Time.deltaTime * 5f);
            if (ConsoleDesk.transform.localPosition.y <= targetHeight)
            {
                ConsoleDesk.transform.localPosition = new Vector3(ConsoleDesk.transform.localPosition.x, targetHeight, ConsoleDesk.transform.localPosition.z);
                isClick = false;
            }
        }
    }

    bool isRight = false;
    bool isClick = false;
    void RightPos()
    {
        isRight =! isRight;
        isClick = true;
    }

    void OnOffMenuPanel()
    {
        if (MenuPanelObj.gameObject.activeSelf)
        {
            MenuPanelObj.gameObject.SetActive(false);
        }
        else
        {
            MenuPanelObj.gameObject.SetActive(true);
        }
    }
}

