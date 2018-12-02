using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
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

        //print(playerName);
        Regex.Replace(playerName, @"\s+", "");
        string path = null;
        path = "Assets/PlayerName.txt";
        File.WriteAllText(path, string.Empty);

        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(playerName);
            }

        }
        UnityEditor.AssetDatabase.Refresh();
        HideMenu();
    }

    private void HideMenu()
    {

        EnterNameObjcet.SetActive(false);


    }






}