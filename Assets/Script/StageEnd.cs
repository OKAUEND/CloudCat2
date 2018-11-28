using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageEnd : MonoBehaviour {

    private PlayerController PlayerScript;

    private Rigidbody2D Player2D;

    // Use this for initialization
    void Start () {
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        Player2D = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!IsTagPlayer(collision.tag))
        {
            return;
        }

        Player2D.velocity = new Vector2(0.0f, 0.0f); ;
        PlayerScript.ContorolMode = false;

        Debug.Log("ステージクリア");


    }

    private bool IsTagPlayer(string tag)
    {
        return "Player" == tag;
    }
}
