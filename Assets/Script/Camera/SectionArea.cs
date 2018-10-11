using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;

public class SectionArea : MonoBehaviour {

    private Rect SectionRect;
    private CameraController cameraController;

    /// <summary>
    /// セクション範囲を設定する
    /// </summary>
    /// <param name="rect"></param>
    public void SetSectionRect(Rect rect)
    {
        this.SectionRect = rect;
        cameraController = GameObject.Find("Camera").GetComponent<CameraController>();
       
        //cameraController.SetSectionRect(SectionRect);
    }

    public void CommitSectionRect()
    {
        if(SectionRect.IsRectNull())
        {
            cameraController.SetSectionRect(SectionRect);
        }
        
    }
}

