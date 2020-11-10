using System;
using UnityEngine;

public class InputEventArgs : EventArgs
{
    private string buttonState;
    public string ButtonState { get => buttonState; set => buttonState = value; }

    public InputEventArgs(KeyCode keyCode)
    {
        ButtonState = keyCode.ToString();
    }
}
