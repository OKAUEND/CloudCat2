using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour {

    private bool MenuLoad = false;

    private float DelayWait = 0.2f;

    private void Start()
    {
        StartCoroutine(MonoBehaviourExtensions.DelayMethod(DelayWait, () =>
         {
             MenuLoad = true;
         }));
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && MenuLoad)
        {
            SceneManager.UnloadSceneAsync("SystemMenu");
        }
    }

    public void OnEnterContinueGame()
    {
        Debug.Log("ゲーム画面へ戻る");
        SceneManager.UnloadSceneAsync("SystemMenu");
    }

    public void LoadStageSelect()
    {
        SceneManager.LoadSceneAsync("StageSelect");
    }

    public void ApplicationExit()
    {
        Application.Quit();
    }

    private void OnDestroy()
    {
        MenuLoad = false;
    }
}
