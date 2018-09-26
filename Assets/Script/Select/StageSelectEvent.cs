using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectEvent : MonoBehaviour {


    private const string ErrorMessage = "ステージデータを参照できません。";

    //GameObject[] StagePoints;

    public void OnClickStagePointOne()
    {
        OnSceneTransition("StageOne");
        //StagePoints = GameObject.FindGameObjectsWithTag("StagePoint");
        
        //CompleteFlagManager.ProgressiveState.Stage1 = CompleteFlagManager.CompleteFlag.NoComplete;
    }

    public void OnClickStageSelect()
    {
        var StageID = StageData.SearchStageID(GetStagePointName());
        OnSceneTransition(StageID);
    }
     
    private void OnSceneTransition(string SceenID)
    {
        Debug.Log(SceenID);
        SceneManager.LoadSceneAsync(SceenID);
    }

    public void OnPointEnterStagePoint()
    {

       
    }

    private string GetStagePointName()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float maxDistance = 10f;

        RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

        if (!hit.collider)
        {
            Debug.Log(hit.collider.gameObject.name);
            return null;
        }

        return hit.collider.gameObject.name;
    }
}
