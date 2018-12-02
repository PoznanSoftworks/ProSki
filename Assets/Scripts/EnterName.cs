using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class EnterName : MonoBehaviour
{

    public GameObject EnterNameObjcet;

    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void SubmitName(string playerName)
    {

        print(playerName);
        string path = null;
        path = "Assets/PlayerName.json";


        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(playerName);
            }

        }

        HideMenu();
    }

    private void HideMenu()
    {

        EnterNameObjcet.SetActive(false);


    }






}