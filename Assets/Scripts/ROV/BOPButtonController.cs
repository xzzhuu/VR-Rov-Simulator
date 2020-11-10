//===================================================
//  Copyright @  HIVE 2020
//  时间：2020-09-03 15:58:47
//  项目名称：VR ROV(Oculus开发)
//  脚本说明：
//        3D操作板3D按键功能事件
//===================================================
using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOPButtonController : MonoBehaviour
{
   
    public Text Txt_State;
    void Start()
    {
      
        TxtDebug();
    }
    public void StartStopDeskChanged(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
          
            TxtDebug();
        }
    }

    public void L1Change(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
           
        }

        TxtDebug();
    }

    public void R1Change(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
           
        }

        TxtDebug();
    }
    public void L2Change(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
           
            
        }

        TxtDebug();
    }
    public void R2Change(InteractableStateArgs obj)
    {
        if (obj.NewInteractableState == InteractableState.ActionState)
        {
         
        }

        TxtDebug();
    }

    void TxtDebug()
    {
      
    }
}
