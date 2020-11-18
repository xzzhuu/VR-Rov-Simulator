using UnityEngine;
using UnityEngine.UI;

public class TooltipUI : MonoBehaviour
{
    [SerializeField]
    private Text text;

    [SerializeField]
    private Text childText;

    TooltipResult result;
    private void Start()
    {
        childText.fontSize = text.fontSize;
        childText.color = text.color;
        childText.fontStyle = text.fontStyle;
        childText.lineSpacing = text.lineSpacing;

    }
    public void Active(TooltipModel tooltipModel)
    {
        this.text.text = tooltipModel.value;
        childText.text = text.text;
        this.result = tooltipModel.result;
        if (tooltipModel.delay > 0f)
        {
            Invoke(nameof(Close), tooltipModel.delay);
        }
        gameObject.SetActive(true);
    }

    //关闭UI 如果有需要运行的方法就执行
    public void Close()
    {
        if (IsInvoking(nameof(Close))) CancelInvoke(nameof(Close));
        text.text = "";
        childText.text = "";
        gameObject.SetActive(false);
        result?.Invoke();
    }
}
