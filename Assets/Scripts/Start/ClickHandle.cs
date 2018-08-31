using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickHandle : MonoBehaviour {

    private void Click()
    {
        SceneManager.LoadScene("Introduction");
    }

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Click);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
