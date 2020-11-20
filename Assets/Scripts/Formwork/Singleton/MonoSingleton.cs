using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T:Component
{
    private static T instance = null;
    private static readonly object locker = new object();

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                lock (locker)
                {
                    instance = FindObjectOfType(typeof(T)) as T;
                    if (instance == null)
                    {
                        GameObject obj = new GameObject(typeof(T).Name);
                        obj.hideFlags = HideFlags.DontSave;
                        obj.hideFlags = HideFlags.HideAndDontSave;
                        instance = (T)obj.AddComponent(typeof(T));
                    }
                }
            }
            return instance;
        }
    }
    protected virtual void Awake()
    {
      //  DontDestroyOnLoad(this.gameObject);
        if (instance == null) instance = this as T;
        else
            Destroy(gameObject);
    }


    /*  另外一种简单写法
    private static T m_instance;

    public static T Instance
    {
        get { return m_instance; }
    }

    //初始化
    protected virtual void Awake()
    {
        m_instance = this as T;
    }
    */
}
