﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (T)GameObject.FindObjectOfType(typeof(T));
                if (instance == null)
                {
                    GameObject go = new GameObject();
                    instance = go.AddComponent<T>();

                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }
}
