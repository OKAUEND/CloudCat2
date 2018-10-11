using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    GameObject Player;
    Rigidbody2D Player2D;
    float JumpForce = 680.0f;
    float WalkUnityForce = 10.0f;
    float maxWalkSpeed = 50.0f;
    //float runSpeed = 0.5f;
    //float Scroll = 20.0f;

    private Rect MobileAreaRect;

    // Use this for initialization
    void Start () {
        Player2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        int PushKey = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Player2D.AddForce(transform.up * this.JumpForce);
            Debug.Log("ジャンプ！");
        }

        if (IsPushKeyLeft()) PushKey = -1;
        if (IsPushKeyRight()) PushKey = 1;

        //float speedx = Mathf.Abs(Player2D.velocity.x);

        //Player2D.AddForce(transform.right * PushKey * WalkForce);
        Player2D.velocity = new Vector2(WalkUnityForce * PushKey, Player2D.velocity.y);

    }

    private bool IsPushKeyLeft()
    {
       return Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
    }

    private bool IsPushKeyRight()
    {
        return Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ;
    }

    private bool IsMaxSpeed(float speedx)
    {
        return speedx < maxWalkSpeed;
    }

    public void SetMobileAreaRect(Rect rect)
    {
        MobileAreaRect = rect;
    }

    public void MovePosition(Vector3 position)
    {
        this.transform.position = position;
    }
}
