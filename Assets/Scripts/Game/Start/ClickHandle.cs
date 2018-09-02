using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Util;
using Config;

public class ClickHandle : MonoBehaviour {

    public class Joy {
        public string name = "joy";
        public int age = 25;
        public byte sex = 1;
        public int satisfy = 60;
        public int money = 2000;
    }

    public void StartClick()
    {
        IOHelper.SetData(Config.Config.SAVE_DATA_FILE_NAME, new Joy());

        SceneManager.LoadScene("Introduction");
    }
}
