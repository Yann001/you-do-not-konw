using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandle : MonoBehaviour {

    public void StartClick()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void QuitGame() 
    {
        Debug.Log("退出游戏啦");
        Application.Quit();
    }
}
