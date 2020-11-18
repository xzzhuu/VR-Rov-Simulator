
//---------------tooltip模型类--------------------

//声明一个提示委托  用于在弹出提示的同时运行其他程序的方法  
public delegate void TooltipResult();
public class TooltipModel 
{
    public string value;//要显示的文字
    public float delay;//延迟多久自动关闭
    public TooltipResult result;
    public TooltipModel(string value,float delay = 1f, TooltipResult result = null)
    {
       
        this.value = value;
        this.delay = delay;
        this.result = result;
    }
}
