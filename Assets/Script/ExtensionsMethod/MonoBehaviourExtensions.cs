using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

static class MonoBehaviourExtensions
{
    public static IEnumerator DelayMethod(float waitTime,Action action)
    {
        Debug.Log("コルーチン");
        yield return new WaitForSeconds(waitTime);
        action();
    }

}
