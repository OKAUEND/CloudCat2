using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileAreaCreate : MonoBehaviour {

    [SerializeField]
    private Transform BasePointObject;

    [SerializeField]
    private float RectHeight;
    [SerializeField]
    private float RectWidht;

    private Rect MobileAreaRect;

    // Use this for initialization
    // Mobile Area
    void Start () {
        MobileAreaRect = new Rect(BasePointObject.position.x, BasePointObject.position.y, RectWidht, RectHeight);
        BasePointObject.GetComponent<MobileSectionArea>().SetMoblieArea(MobileAreaRect);
	}

    void OnDrawGizmos()
    {
        Vector3 lower_left = new Vector3(MobileAreaRect.xMin, MobileAreaRect.yMax, 0);
        Vector3 upper_left = new Vector3(MobileAreaRect.xMin, MobileAreaRect.yMin, 0);
        Vector3 lower_right = new Vector3(MobileAreaRect.xMax, MobileAreaRect.yMax, 0);
        Vector3 upper_right = new Vector3(MobileAreaRect.xMax, MobileAreaRect.yMin, 0);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(lower_left, upper_left);
        Gizmos.DrawLine(upper_left, upper_right);
        Gizmos.DrawLine(upper_right, lower_right);
        Gizmos.DrawLine(lower_right, lower_left);
    }
}
