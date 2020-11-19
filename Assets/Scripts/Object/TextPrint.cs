using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 用于文本信息显示及延时清空
/// </summary>
public class TextPrint : MonoBehaviour
{
    void Start()
    {
    }
    /// <summary>
    /// 文字显示状态信息
    /// </summary>
    /// <param name="str"></param>
    public void PrintMessageStr(string printStr)
    {
        StartCoroutine(ClearStr(printStr));
    }

    
    public void PrintMessageText(Text printText)
    {
        StartCoroutine(ClearText(printText));
    }

    IEnumerator ClearText(Text text, float time = 2F)
    {
        
        yield return new WaitForSeconds(time);
        text.text = string.Empty;
    }

    IEnumerator ClearStr(string str, float time = 2F)
    {

        yield return new WaitForSeconds(time);
        str = string.Empty;

    }
}
