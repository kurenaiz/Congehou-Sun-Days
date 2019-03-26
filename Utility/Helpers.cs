﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IEnumerableExtension
{       
    public static IEnumerable<T> Safe<T>(this IEnumerable<T> source)
    {
        if (source == null)
        {
            yield break;
        }

        foreach (var item in source)
        {
            yield return item;
        }
    }
}

public static class Vector2Extension
{

    public static Vector2 Rotate(this Vector2 v, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }
}
