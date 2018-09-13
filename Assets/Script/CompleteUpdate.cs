using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteUpdate : MonoBehaviour {

    //CompleteFlagManager CompleteFlag;

    // Use this for initialization
    void Start()
    {
        //CompleteFlagManager.ProgressiveState.Stage1 = CompleteFlagManager.CompleteFlag.NoComplete;
        Debug.Log(StageData.ProgressiveState.Stage1.ToString());
    }

    //// Update is called once per frame
    //void Update () {

    //}



}
