//===================================================
//  Copyright @  HIVE 2020
//  作者：谢铸
//  时间：2020-08-07 11:19:01
//  项目名称：VR ROV(Oculus开发)
//  项目版本：0.1
//  脚本说明：
//===================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    Text messageText;//保存设置操作信息提示文本
    // Start is called before the first frame update
    void Start()
    {
        messageText = GetComponent<Text>();
        messageText.text = "";
    }
    
    /// <summary>
    /// 文字提示
    /// </summary>
    /// <param name="str"></param>
    public void ShowMessage(string str)
    {
        messageText.text = str;
        StartCoroutine(nameof(DelayEmptyMessage));
    }
    IEnumerator DelayEmptyMessage()
    {
        yield return new WaitForSeconds(1f);
        messageText.text = "";
    }
}
