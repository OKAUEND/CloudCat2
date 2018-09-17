using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;

public class WarpScript : MonoBehaviour {

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject WarpPoint;

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("入ってるよ");
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Wキー入力");
            Debug.Log(WarpPoint.ToString());
            
            Player.transform.position = WarpPoint.transform.position;
            //_camera.transform.position = new Vector3(WarpPoint.transform.position.x,0,-10);

        }
    }

}
