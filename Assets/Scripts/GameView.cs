using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameView : MonoBehaviour
{
    public Text CurrentScore;
    public Text GameNameText;
    public Button PlayButton;
    public void showGameOverScreen()
    {
        PlayButton.gameObject.SetActive(true);
        GameNameText.gameObject.SetActive(true);
    }

    public void showNewScore(int score){
        CurrentScore.text = score.ToString();
    }

    public void startNewGame(){
        SceneManager.LoadScene("main");
    }

}
