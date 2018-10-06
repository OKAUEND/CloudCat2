using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAreaChange : MonoBehaviour {

    [SerializeField]
    private Transform SectionArea;

    [SerializeField]
    private Transform MobileArea;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (TagUtility.getParentTagName(collision.gameObject.tag) == "Player")
        {
            Debug.Log("当たり判定OK");
            SectionArea.GetComponent<SectionArea>().CommitSectionRect();
            MobileArea.GetComponent<MobileSectionArea>().CommitMobileArea();
        }
    }
}
