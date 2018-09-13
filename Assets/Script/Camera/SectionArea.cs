using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("Rectセッティング");
        //cameraController.SetSectionRect(SectionRect);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (TagUtility.getParentTagName(collision.gameObject.tag) == "Player")
    //    {
    //        Debug.Log("当たり判定OK");
    //        cameraController.SetSectionRect(SectionRect);
    //    }
    //}

    public void CommitSectionRect()
    {
        if(SectionRect != null)
        {
            cameraController.SetSectionRect(SectionRect);
        }
    }

}

