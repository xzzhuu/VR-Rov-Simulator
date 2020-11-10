using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T:Component
{
    private static readonly object syslock = null;
    private static T _instance;
    public static T Instance
    {
        get{
            if (_instance == null)
            {
                lock (syslock)
                { //锁一下，避免多线程出问题
                    _instance = FindObjectOfType(typeof(T)) as T;
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        //obj.hideFlags = HideFlags.DontSave;
                        obj.hideFlags = HideFlags.HideAndDontSave;
                        _instance = (T)obj.AddComponent(typeof(T));
                    }
                }
            }
            return _instance;
        }
    }


    //  这是为了不要在切换场景时单例消失，可以删掉
    public virtual void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static bool IsBuild
    {
        get
        {
            return _instance != null;
        }
    }
}
