using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour {

    private Vector3 ReturnPoint;

    private PlayerController PlayerScript;
    private GameObject Camera;

    private float Damage = 10f;

    private float ReturnSecondes = 2.0f;

    // Use this for initialization
    void Start () {
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        Camera = GameObject.Find("CameraRig");
        var pointtransform = transform.Find("ReturnPoint");
        ReturnPoint = pointtransform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if(!IsTagPlayer(collision.tag))
        //{
        //    return;
        //}
        
        StartCoroutine(MonoBehaviourExtensions.DelayMethod(ReturnSecondes, () =>
        {
            //Playerオブジェクトの移動メソッドを呼び出し
            //Player.transform.position = new Vector3(-8f, -1.380f, 0);
            PlayerScript.MovePosition(ReturnPoint);
        }));

        //Debug.Log("落下");


        //Playerへダメージ処理

        //Cameraオブジェクトの移動メソッドを呼び出し
        //Camera.transform.position = new Vector3(0.8f, 0f, -10f);
    }

    private bool IsTagPlayer(string tag)
    {
        return "Player" == tag;
    }
}
