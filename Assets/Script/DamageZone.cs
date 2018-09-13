using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour {

    private GameObject Player;
    private GameObject Camera;

    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player");
        Camera = GameObject.Find("CameraRig");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("落下");
        //Player.transform.position = new Vector3(-8f, -1.380f, 0);
        //Camera.transform.position = new Vector3(0.8f, 0f, -10f);
    }
}
