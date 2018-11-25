using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/// <summary>
/// This class is used as Menu for start of game.
/// </summary>
public class ButtonsManagment : MonoBehaviour {
    [Header("ButtonsMenu")]
    public Button start;
    public Button scoreBoard;
    public Button credits;

    /// <summary>
    /// At start each button is set with listner
    /// </summary>
    void Start () {
        Button btn1 = start.GetComponent<Button>();
        btn1.onClick.AddListener(StartScene);

        Button btn2 = scoreBoard.GetComponent<Button>();
        btn2.onClick.AddListener(ScoreBoardScene);

        Button btn3 = credits.GetComponent<Button>();
        btn3.onClick.AddListener(CreditsScene);


    }
    

    public void StartScene()
    {
        Debug.Log("ProSkiAndroid");
        SceneManager.LoadScene("ProSkiAndroid");
    }

    public void ScoreBoardScene()
    {
        Debug.Log("ScoreBoard");
        SceneManager.LoadScene("ScoreBoard");
    }

    public void CreditsScene()
    {

    }

}
