﻿using JetBrains.Annotations;
using UnityEngine;

public static class D
{
    /// <summary>
    /// Ability to redirect tracepoint output to Unity console
    /// </summary>
    [UsedImplicitly]
    public static T Log<T>(T s)
    {
        Debug.Log(s);
        return s;
    }
    
    /// <summary>
    /// Ability to redirect tracepoint output to Unity console
    /// </summary>
    [UsedImplicitly]
    public static T LogEr<T>(T s)
    {
        Debug.LogError(s);
        return s;
    }
}
