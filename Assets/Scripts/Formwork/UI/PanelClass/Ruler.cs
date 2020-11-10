using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruler : MonoBehaviour
{

    public Text txtValue;
    private float mValue = 0f;
    public Slider SL;
    public bool usePercent = false;
    public bool isMiddle = false;
    public enum TypeEnd
    {
        TYPE_None,
        TYPE_Bar,
        TYPE_Percent,
        TYPE_Degree,
        TYPE_Unit,
        TYPE_M_S
      
    }
    public TypeEnd typeEnd = TypeEnd.TYPE_Bar;
    private string typeEndStr = "Bar";
    private void Start()
    {
        switch (typeEnd)
        {
            case TypeEnd.TYPE_None:
                typeEndStr = "";
                break;
            case TypeEnd.TYPE_Bar:
                typeEndStr = " Bar";
                break;
            case TypeEnd.TYPE_Percent:
                typeEndStr = "%";
                break;
            case TypeEnd.TYPE_Degree:
                typeEndStr = "°";
                break;
            case TypeEnd.TYPE_Unit:
                typeEndStr = "Units";
                break;
            case TypeEnd.TYPE_M_S:
                typeEndStr = "m/s";
                break;
            default:
                typeEndStr = "";
                break;
        }
        mValue = SL.value;
        txtValue.text = usePercent ? (mValue * 100 / SL.maxValue).ToString("#0.00") + typeEndStr : mValue.ToString() + typeEndStr;
    }
    public void SetValue(float value)
    {
        mValue = value;
        txtValue.text = usePercent ? (value * 100 / SL.maxValue).ToString("#0.00") + typeEndStr : value.ToString() + typeEndStr;
    }
    public void OnBtnClick(bool isAdd)
    {
        float tempValue = isMiddle ? (SL.maxValue - SL.minValue)  : SL.maxValue;
        mValue =  isAdd ? tempValue/10+mValue :-tempValue/10+mValue;
        if (mValue >= SL.maxValue) mValue = SL.maxValue;
        if (mValue <= SL.minValue) mValue = SL.minValue;
        SL.normalizedValue = isMiddle ? (0.5f + (mValue /tempValue) ): (mValue / tempValue);
        txtValue.text = usePercent ? (mValue * 100 / SL.maxValue).ToString("#0.00") + typeEndStr : mValue.ToString() + typeEndStr;
    }
}
