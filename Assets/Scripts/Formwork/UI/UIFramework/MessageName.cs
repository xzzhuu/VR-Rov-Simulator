using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用一个单独的类或配置文件保存消息名称
/// 避免字符串拼写错误的尴尬
/// </summary>
public class MessageName
{
    //更改标题.
    public const string MSG_CHANGE_TITTLE = "Msg_Change_Tittle";
    public const string MSG_SHOW_BTN_BACK = "Msg_Show_Btn_Back";

   
    //ROV操作消息.
    public const string MSG_MOVE_FWD = "msg_move_fwd";
    public const string MSG_MOVE_BWD = "msg_move_bwd";
    public const string MSG_MOVE_LEFT = "msg_move_left";
    public const string MSG_MOVE_RIGHT = "msg_move_right";
    public const string MSG_MOVE_UP = "msg_move_up";
    public const string MSG_MOVE_DOWN = "msg_move_down";
    public const string MSG_MOVE_STOP = "msg_move_stop";
    public const string MSG_MOVE_TURN_L = "msg_move_turn_l";
    public const string MSG_MOVE_TURN_R = "msg_move_turn_r";

    //TMS操作信息
    public const string MSG_ROPE_REDUCE = "msg_rope_reduce";
    public const string MSG_ROPE_ADD = "msg_rope_add";
}
//请根据项目的实际情况扩展更多的消息名...
