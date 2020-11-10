using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 左手手柄UI面板，用于切换按键的ROV操作功能
/// </summary>
public class StateSwitchPanel : MonoBehaviour
{
    [Header("手柄按键逻辑切换")]
    public Toggle Toggle_L1_RobiCtl;
    public Toggle Toggle_L2_GripperCtl;

    public Toggle Toggle_R1_RovMovementPoseCtl;
    public Toggle Toggle_R2_ArmCtl;

    LTouchController lTouchController;
    RTouchController rTouchController;
  

    private void Awake()
    {
        lTouchController = GameObject.Find("OVRButtonInput").GetComponent<LTouchController>();
        rTouchController = GameObject.Find("OVRButtonInput").GetComponent<RTouchController>();
    
      
    }
    void Start()
    {
        SetToggleInteractable(false);

        Toggle_L1_RobiCtl.onValueChanged.AddListener((bool a) => { On_L1_RobiCtl(); });
        Toggle_R1_RovMovementPoseCtl.onValueChanged.AddListener((bool a) => { On_R1_RovMovementPoseCtl(); });
        Toggle_L2_GripperCtl.onValueChanged.AddListener((bool a) => { On_L2_GripperCtl(); });
        Toggle_R2_ArmCtl.onValueChanged.AddListener((bool a) => { On_R2_ArmCtl(); });

     

        ROVStateData.GetInstance().CompleteTotalSettingEvent += CompleteRovSetting;
        ROVStateData.GetInstance().UncompleteTotalSettingEvent += UncompleteRovSetting;
    }

    /// <summary>
    /// 当满足ROV操作条件时初始化手柄功能控件  按键点击
    /// </summary>
    public void CompleteRovSetting()
    {
        SetToggleInteractable(true);
        InitToggleIsOn();
        lTouchController.LeftControl = LTouchController.LTouchCtlType.L1;
        rTouchController.RightControl = RTouchController.RTouchCtlType.R1;
    }
    public void UncompleteRovSetting()
    {
        lTouchController.LeftControl = LTouchController.LTouchCtlType.None;
        rTouchController.RightControl = RTouchController.RTouchCtlType.None;
    }
    /// <summary>
    /// 设置开关Interactable属性
    /// </summary>
    /// <param name="able"></param>
    void SetToggleInteractable(bool able)
    {
        Toggle_L1_RobiCtl.interactable = able;
        Toggle_L2_GripperCtl.interactable = able;
        Toggle_R1_RovMovementPoseCtl.interactable = able;
        Toggle_R2_ArmCtl.interactable = able;
    }
    void InitToggleIsOn()
    {
        Toggle_L1_RobiCtl.isOn = true;
        Toggle_L2_GripperCtl.isOn = false;
        Toggle_R1_RovMovementPoseCtl.isOn = true;
        Toggle_R2_ArmCtl.isOn = false;

    }
    //L1
    public void On_L1_RobiCtl()
    {
        if (Toggle_L1_RobiCtl.isOn)
        {

            lTouchController.LeftControl = LTouchController.LTouchCtlType.L1;
            Toggle_L2_GripperCtl.isOn = false;
        }

    }

    //R1
    public void On_R1_RovMovementPoseCtl()
    {
        if (Toggle_R1_RovMovementPoseCtl.isOn)
        {
            rTouchController.RightControl = RTouchController.RTouchCtlType.R1;
            Toggle_R2_ArmCtl.isOn = false;
        }
    }

    //L2
    public void On_L2_GripperCtl()
    {
        if (Toggle_L2_GripperCtl.isOn)
        {

            lTouchController.LeftControl = LTouchController.LTouchCtlType.L2;
            Toggle_L1_RobiCtl.isOn = false;
        }
    }

    //R2
    public void On_R2_ArmCtl()
    {
        if (Toggle_R2_ArmCtl.isOn)
        {

            rTouchController.RightControl = RTouchController.RTouchCtlType.R2;
            Toggle_R1_RovMovementPoseCtl.isOn = false;
        }
    }
}

