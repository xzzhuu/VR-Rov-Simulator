using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnClickEventHandle<InputEventArgs>(object sender, InputEventArgs e);
public class Test : MonoBehaviour
{

    public event OnClickEventHandle<InputEventArgs> OnClickEvent;

    protected void OnTest(KeyCode keyCode)
    {
        if (this.OnClickEvent != null)
        {
           InputEventArgs inputEventArgs = new InputEventArgs(keyCode);
           OnClickEvent(this, inputEventArgs);
        }
    }
     void Start()
    {
        OnClickEvent += Method;
    }

    private void OnGUI()
    {
        if (Input.anyKeyDown)
        {
            Event e = Event.current;
            if (e != null && e.isKey && e.keyCode != KeyCode.None)
            {
                OnTest(e.keyCode);
            }
        }
    }

    public void Method(object o, InputEventArgs e)
    {
        Debug.Log("当前按下:" + e.ButtonState);
    }

}
