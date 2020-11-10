
/// <summary>
/// 消息传递的参数
/// </summary>
public class MessageData
{

    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */

    public bool valueBool;
    public int valueInt;
    public float valueFloat;
    public string valueString;

    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public MessageData(bool value)
    {
        valueBool = value;
    }

    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public MessageData(int value)
    {
        valueInt = value;
    }

    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public MessageData(float value)
    {
        valueFloat = value;
    }

    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public MessageData(string value)
    {
        valueString = value;
    }

}
