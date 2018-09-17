using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionController : MonoBehaviour {

    // セクションのカメラ範囲制御
    [SerializeField]
    private Transform SectionArea;

    [SerializeField]
    private float RectWidth, RectHeight, ColliderDepth;

    private Rect SectionRect;

    // マネージャ
    //private GlobalManager globalManager;

    void Start()
    {
       //マネージャ取得
       //globalManager = GlobalManager.getInstance();

       // セクション範囲定義
       SectionRect = new Rect(SectionArea.position.x, SectionArea.position.y, RectWidth, RectHeight);

        // セクション判定用オブジェクトに範囲を設定
        SectionArea.GetComponent<SectionArea>().SetSectionRect(SectionRect);

        // CameraControllerにセクション範囲を渡すための判定定義
        SectionArea.transform.position = new Vector3(SectionRect.center.x, SectionRect.center.y, transform.position.z);
        //BoxCollider2D boxCollider = ChangeArea.GetComponent<BoxCollider2D>();
        //boxCollider.size = new Vector3(SectionRect.width, SectionRect.height, ColliderDepth);
    }

    void OnDrawGizmos()
    {

        Vector3 lower_left = new Vector3(SectionRect.xMin, SectionRect.yMax, 0);
        Vector3 upper_left = new Vector3(SectionRect.xMin, SectionRect.yMin, 0);
        Vector3 lower_right = new Vector3(SectionRect.xMax, SectionRect.yMax, 0);
        Vector3 upper_right = new Vector3(SectionRect.xMax, SectionRect.yMin, 0);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(lower_left, upper_left);
        Gizmos.DrawLine(upper_left, upper_right);
        Gizmos.DrawLine(upper_right, lower_right);
        Gizmos.DrawLine(lower_right, lower_left);
    }
}
