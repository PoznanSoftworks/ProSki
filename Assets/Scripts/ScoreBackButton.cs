using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/// <summary>
/// This class is used as Menu for start of game.
/// </summary>
public class ScoreBackButton : MonoBehaviour
{
    [Header("ButtonsMenu")]
    public Button start;


    /// <summary>
    /// At start each button is set with listner
    /// </summary>
    void Start()
    {
        Button btn1 = start.GetComponent<Button>();
        btn1.onClick.AddListener(StartScene);


    }


    public void StartScene()
    {
        Debug.Log("menu");
        SceneManager.LoadScene("menu");
    }


}
