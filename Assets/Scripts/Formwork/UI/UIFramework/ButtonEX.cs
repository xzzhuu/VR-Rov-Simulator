using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonEX : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{
    public Vector2 position;
    public bool interactable = true;

    public bool invokeOnce = false;//是否只调用一次  
    private bool hadInvoke = false;//是否已经调用过  

    public float interval = 0.1f;//按下后超过这个时间则认定为"长按"  
    private bool isPointerDown = false;
    private float recordTime;

    public UnityEvent onClickDown = new UnityEvent();//按下时调用  
    public UnityEvent onPress = new UnityEvent();//按住时调用  ；；
    public UnityEvent onRelease = new UnityEvent();//松开时调用 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((invokeOnce && hadInvoke) || interactable == false) return;
        if (isPointerDown)
        {
            if ((Time.time - recordTime) > interval)
            {
                onPress.Invoke();
                hadInvoke = true;
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPointerDown = true;
        recordTime = Time.time;
        position = eventData.position;
        onClickDown.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPointerDown = false;
        hadInvoke = false;
        position = eventData.position;
        onRelease.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPointerDown = false;
        hadInvoke = false;
        position = eventData.position;
        //onRelease.Invoke();
    }
    void OnDisable()
    {
        isPointerDown = false;
    }
}
