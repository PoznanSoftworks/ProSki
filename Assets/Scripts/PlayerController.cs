using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class PlayerController : MonoBehaviour {


    private ConstantForce cf;
    private Rigidbody rb;
    private float timer = 0.0f;
    private ScoreBoard scoreBoard;
    public int topSpeed = 5;

    void Start()
    {
        cf = GetComponent<ConstantForce>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            timer += Time.deltaTime;
            rb.AddRelativeForce(Vector3.right * 1);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (timer < 0.5)
            {
                rb.AddRelativeForce(Vector3.right * 75);
            }
            else
            {
                timer = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            timer += Time.deltaTime;
            rb.AddRelativeForce(Vector3.left * 1);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (timer < 0.5)
            {
                rb.AddRelativeForce(Vector3.left * 75);
            }
            else
            {
                timer = 0;
            }
        }

        if (rb.velocity.magnitude > topSpeed)
        {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            int points = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().points;
            print(points);
            SaveItemInfo(points);
        }

    }


    public void SaveItemInfo(int points)
    {
     string readMeText;
     string path = null;
     path = "Assets/score.json";
     string Score = points.ToString();

        DateTime localDate = DateTime.Now;


        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
     {

            using (StreamReader readtext = new StreamReader(fs))
            {
                readMeText = readtext.ReadToEnd();
            }


            print(readMeText);
       
     }


        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {

            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(readMeText  + localDate+ " " + (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().name + " Points " + Score));
            }


        }



        UnityEditor.AssetDatabase.Refresh();
    }




}
