using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSceneUIController : MonoBehaviour {


    GameObject StageName;
    GameObject StageDesc;

	// Use this for initialization
	void Start () {
        //StageName = GameObject.Find("");
        StageName = transform.Find("StageName").gameObject;
        StageDesc = transform.Find("StageDesc").gameObject;

    }

    public void ShowStageName(string name)
    {
        StageName.GetComponent<Text>().text = name;
    }

    public void ShowStageDesc(string desc)
    {
        StageDesc.GetComponent<Text>().text = desc;
    }
}
