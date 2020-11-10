using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleRuler : MonoBehaviour
{
    public Text txtValue;
    public Slider SL;
    private float mValue = 0f;
    public bool usePercent = false;
    // Start is called before the first frame update
    void Start()
    {
        mValue = SL.value;
    }
    public void SetValue(float value)
    {
        mValue = value;
        txtValue.text = usePercent ? (value * 100 / SL.maxValue).ToString("#0.00") + "%" : value.ToString() + " °";
    }
    public void OnBtnClick(bool isAdd)
    {

        float temp = isAdd ? (SL.maxValue-SL.minValue) / 10f : -(SL.maxValue - SL.minValue) / 10f;
        mValue = mValue + temp;
        if (mValue >= SL.maxValue) mValue = SL.maxValue;
        if (mValue <= SL.minValue) mValue = SL.minValue;
        SL.normalizedValue =0.5f+(mValue / (SL.maxValue-SL.minValue));
        txtValue.text = usePercent ? (mValue * 100 / SL.maxValue).ToString("#0.00") + "%" : mValue.ToString() + " °";

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
