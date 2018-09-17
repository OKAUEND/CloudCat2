using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private float cameraRangeWidth, cameraRangeHeight;

    private GameObject mainCamera;
    private GameObject Player;

    private Camera CameraObject;

    private Rect SectionRect;
    private Vector3 top_left, bottom_left, top_right, bottom_right;

    private float LeftX = 0f;
    private float RightX = 1f;

    private float LeftY = 0f;
    private float RightY = 1f;

    private void Start()
    {
        Player = GameObject.Find("Player");
        mainCamera = GameObject.Find("MainCamera");
    }

    private void Update()
    {
        transform.position = Player.transform.position;

        Vector3 newPosition = transform.position;

        // カメラ描画範囲の上下左右を取得
        float distance = Vector3.Distance(mainCamera.transform.position, Player.transform.position);
        Debug.Log(distance.ToString());
        bottom_left = mainCamera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(LeftX, LeftY, 2));
        top_right = mainCamera.GetComponent<Camera>().ViewportToWorldPoint(new Vector3(RightX, RightY, 2));
        top_left = new Vector3(bottom_left.x, top_right.y, bottom_left.z);
        bottom_right = new Vector3(top_right.x, bottom_left.y, top_right.z);

        cameraRangeWidth = Vector3.Distance(bottom_left, bottom_right);
        cameraRangeHeight = Vector3.Distance(bottom_left, top_left);

        // カメラ位置をセクション範囲内に収める
        float newX = Mathf.Clamp(newPosition.x, SectionRect.xMin + cameraRangeWidth / 2, SectionRect.xMax - cameraRangeWidth / 2);
        float newY = Mathf.Clamp(newPosition.y, SectionRect.yMin + cameraRangeHeight / 2, SectionRect.yMax - cameraRangeHeight / 2);

        transform.position = new Vector3(newX, newY, -10);

    }

    void OnDrawGizmos()
    {
        // カメラ描画範囲を表示
        Debug.Log("緑色ドローイング開始");
        Gizmos.color = Color.green;
        Gizmos.DrawLine(bottom_left, top_left);
        Gizmos.DrawLine(top_left, top_right);
        Gizmos.DrawLine(top_right, bottom_right);
        Gizmos.DrawLine(bottom_right, bottom_left);
        Debug.Log("緑色ドローイング終了");
    }

    public void SetSectionRect(Rect SectionRect)
    {
        this.SectionRect = SectionRect;
    }
}
