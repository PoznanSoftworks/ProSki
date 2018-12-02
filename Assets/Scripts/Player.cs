using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player : MonoBehaviour {

    public int points;
    public string name;
    public float speed;


    private void Start()
    {
        string readMeText;
        string path = null;
        path = "Assets/PlayerName.json";


        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {

            using (StreamReader readtext = new StreamReader(fs))
            {
                readMeText = readtext.ReadToEnd();
            }


        }
        name = readMeText;
    }
}
