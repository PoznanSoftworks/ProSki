using System;
using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class ReadScoreFromBoard : MonoBehaviour {

    public Text scoreBoard;
	// Use this for initi1alization
	void Start () {
        string readMeText;
        string path = null;
        path = "Assets/score.txt";

        DateTime localDate = DateTime.Now;


        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {

            using (StreamReader readtext = new StreamReader(fs))
            {
                readMeText = readtext.ReadToEnd();
            }

        }


        scoreBoard.text += readMeText;


        UnityEditor.AssetDatabase.Refresh();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
