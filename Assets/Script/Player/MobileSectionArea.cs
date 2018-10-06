using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.Common;

public class MobileSectionArea : MonoBehaviour {

    private Rect MoblieAreaRect;

    private PlayerController PlayerScript;

    private void Start()
    {
        PlayerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void SetMoblieArea(Rect rect)
    {
        MoblieAreaRect = rect;
    }

    public void CommitMobileArea()
    {
        if (RectExtra.IsRectNull(MoblieAreaRect))
        {
            PlayerScript.SetMobileAreaRect(MoblieAreaRect);
        }
    }
}
