using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSceneUIController : MonoBehaviour {


    GameObject StageName;
    GameObject StageDesc;

	// Use this for initialization
	void Start () {
        //StageName = GameObject.Find("");
        StageName = transform.Find("StageName").gameObject;
        StageDesc = transform.Find("StageDesc").gameObject;
    }

}
