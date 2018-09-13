using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInti /*: MonoBehaviour */{

    [RuntimeInitializeOnLoadMethod]
    static void OnStartupScreenSizeInti()
    {
        Screen.SetResolution(1280, 768, false, 60);
        Debug.Log("初期設定");
    }


    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
}
