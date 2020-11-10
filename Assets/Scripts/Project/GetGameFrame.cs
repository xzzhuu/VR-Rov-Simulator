//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-09-04 10:48:16
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：
//           计算项目运行帧率
//           绘制帧率显示颜色
//           UI面板显示
//   注意:脚本挂载在Canvas上
//===================================================
using UnityEngine;
using UnityEngine.UI;

public enum DrawType
{
    None,
    GUI,
    UGUI,
    All
}

[System.Reflection.Obfuscation(Exclude = true)]
public class GetGameFrame : MonoBehaviour
{
    private long mFrameCount = 0;
    private long mLastFrameTime = 0;
    static long mLastFps = 0;


    Text frameText;//显示帧率的UI Text

    GameObject FramePanel;

    public DrawType drawType = DrawType.UGUI;

    void Start()
    {
        FramePanel = this.transform.Find("FramePanel").gameObject;
        if (drawType == DrawType.UGUI || drawType == DrawType.All)
        {
            if (FramePanel.gameObject.activeSelf == false)
            {
                FramePanel.gameObject.SetActive(true);
            }
            frameText = FramePanel.transform.Find("Txt_Frame").GetComponent<Text>();
        }
        else
        {
            FramePanel.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (drawType == DrawType.None) return;

        UpdateTick();
        if (drawType == DrawType.UGUI || drawType == DrawType.All)
            DrawColorByUGUI();

    }

    private void UpdateTick()
    {
        if (true)
        {
            mFrameCount++;
            long nCurTime = TickToMilliSec(System.DateTime.Now.Ticks);
            if (mLastFrameTime == 0)
            {
                mLastFrameTime = TickToMilliSec(System.DateTime.Now.Ticks);
            }

            if ((nCurTime - mLastFrameTime) >= 1000)
            {
                long fps = (long)(mFrameCount * 1.0f / ((nCurTime - mLastFrameTime) / 1000.0f));
                mLastFps = fps;
                mFrameCount = 0;
                mLastFrameTime = nCurTime;
            }
        }
    }
    public static long TickToMilliSec(long tick)
    {
        return tick / (10 * 1000);
    }

    void DrawColorByUGUI()
    {
        if (mLastFps > 70)
        {
            frameText.color = new Color(0, 1, 0);
        }
        else if (mLastFps > 60)
        {
            frameText.color = new Color(1, 0.5f, 0);
        }
        else
        {
            frameText.color = new Color(1, 0, 0);
        }
        frameText.text = "Fps: " + mLastFps;
    }

    void OnGUI()
    {
        if (drawType == DrawType.All || drawType == DrawType.GUI)
        {
            if (mLastFps > 70)
            {
                GUI.color = new Color(0, 1, 0);
            }
            else if (mLastFps > 60)
            {
                GUI.color = new Color(1, 0.5f, 0);
            }
            else
            {
                GUI.color = new Color(1, 0, 0);
            }

            GUI.Label(new Rect(50, 32, 64, 24), "Fps: " + mLastFps);
        }
    }


}
