using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;

public class Slippingfloor : MonoBehaviour {

    private BoxCollider2D FloorCollider;

    private void Start()
    {
        FloorCollider = this.transform.GetComponent<BoxCollider2D>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(!IsTagPlayer(collision.tag))
        {
            return;
        }

        if (IsDownKey())
        {
            PlayerSlippingThrough();
        }
    }

    private void PlayerSlippingThrough()
    {
        StartCoroutine(MonoBehaviourExtensions.DelayMethod(1f, () =>
        {
            //長押し判定
            if (!IsDownKey())
            {
                return;
            }

            FloorCollider.enabled = false;

            EnableBoxCollider();
        }));
    }

    private void EnableBoxCollider()
    {
        StartCoroutine(MonoBehaviourExtensions.DelayMethod(1f, () =>
        {
            FloorCollider.enabled = true;
        }));

    }

    private bool IsTagPlayer(string tag)
    {
        return "Player" == tag;
    }

    private bool IsDownKeyOnePush()
    {
        return Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
    }

    private bool IsDownKey()
    {
        return Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
    }
}
