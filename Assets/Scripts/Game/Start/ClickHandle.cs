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

        Joy joy = (Joy)IOHelper.GetData(Config.Config.SAVE_DATA_FILE_NAME, typeof(Joy));

        Debug.Log(joy.name);
        Debug.Log(joy.age);
        Debug.Log(joy.money);

        SceneManager.LoadScene("Introduction");
    }
}
