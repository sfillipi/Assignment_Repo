﻿using System.Collections;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get { return instance; }
    }

    public static bool IsInitalized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] trying to instantiate a" +
                " second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        // if this object is destroyed, make instance null so another can be created
        if (instance == this)
        {
            instance = null;
        }
    }
}

