using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuSceneLoad : MonoBehaviour {

    private string MenuSceneName = "SystemMenu";

    private bool MenuLoad;

    private Pausing _Pausing;

	// Use this for initialization
	void Start () {
        SceneManager.sceneLoaded += OnSceneLoad;
        SceneManager.sceneUnloaded += OnSceneUnload;

        _Pausing = GameObject.Find("PauseManager").GetComponent<Pausing>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape) && MenuLoad == false)
        {
            MenuLoad = true;
            Debug.Log("メニュー展開");
            SceneManager.LoadScene(MenuSceneName, LoadSceneMode.Additive);
        }
	}

    private void OnSceneLoad(Scene current,LoadSceneMode mode)
    {
        //GameSceneのGameObjectを停止させる
        _Pausing.SetPause();
    }

    private void OnSceneUnload(Scene current)
    {
        MenuLoad = false;

        //GameSceneのポーズ状態を解除
        _Pausing.SetResume();

    }

    private void OnDestroy()
    {
        SceneManager.sceneUnloaded -= OnSceneUnload;
    }
}
