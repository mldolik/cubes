﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer<T> : MonoBehaviour
{
    public abstract void OnSubjectUpdate(T newState);
}
