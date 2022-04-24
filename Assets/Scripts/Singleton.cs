using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError($"There is no instance of a singleton {typeof(T)}!!");
            return instance;
        }
    }

    public static bool IsInitialized { get; private set; }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
            IsInitialized = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Debug.LogError($"There are multiple objects of a singleton {typeof(T)}!! Destroying myself...");
            Destroy(this.gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
            IsInitialized = false;
        }
    }
}