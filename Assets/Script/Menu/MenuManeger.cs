using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManeger : MonoBehaviour {

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
}
