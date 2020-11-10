//===================================================
//  Copyright @  HIVE 2020
//  作者：谢铸
//  时间：2020-08-12 15:14:28
//  项目名称：VR ROV(Oculus开发)
//  项目版本：0.1
//  脚本说明：摄像机图像黑白渲染效果
//===================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayEffect : MonoBehaviour
{
    public Shader curShader;
    [Range(0,1)]
    public float grayScaleAmount = 0f;
    private Material curMaterial;

    #region Properties
    Material material
    {
        get
        {
            if (curMaterial == null)
            {
                curMaterial = new Material(curShader);
                curMaterial.hideFlags = HideFlags.HideAndDontSave;
            }
            return curMaterial;
        }
    }
    #endregion
    // Use this for initialization
    void Start()
    {
        if (!curShader && !curShader.isSupported)
        {
            enabled = false;
        }
    }
   void Update () {

            //grayScaleAmount = Mathf.Lerp(grayScaleAmount, 0.0f, Time.deltaTime * 5F);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (curShader != null)
        {
            material.SetFloat("_LuminosityAmount", grayScaleAmount);
            Graphics.Blit(source, destination, material);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }

    bool onGrayEffect;
    /// <summary>
    /// 屏幕黑白效果控制接口
    /// </summary>
    /// <param name="onGrayEffect">是否开启效果</param>
    public void EffectGrayCtl(bool onGrayEffect)
    {
        this.onGrayEffect = onGrayEffect;
        if (this.onGrayEffect) grayScaleAmount =Mathf.Lerp(grayScaleAmount,1f,0.5f);
        else grayScaleAmount = Mathf.Lerp(grayScaleAmount, 0f, 0.5f);
    }

    private void OnDisable()
    {
        if (curMaterial)
        {
            DestroyImmediate(curMaterial);
        }
    }
}
