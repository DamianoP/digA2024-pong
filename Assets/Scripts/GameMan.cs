using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour{
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;
    public GameObject p1Score;
    public GameObject p2Score;
    private int _localP1Score=0;
    private int _localP2Score=0;
    private int _maxScore = 5;
    public void Goal(bool p1){
        Debug.Log("Goal");
        if (!p1){ // <- not
            _localP1Score++;
            p1Score.GetComponent<TextMeshProUGUI>().text = _localP1Score.ToString();
        }
        else{
            _localP2Score++;
            p2Score.GetComponent<TextMeshProUGUI>().text = _localP2Score.ToString();
        }
        if (_localP1Score >= _maxScore || _localP2Score >= _maxScore){ // se è stato raggiungo il max score
            // carico la scena della vittoria passando come parametro alla scena chi ha vinto
            int winner;
            if (!p1){
                winner = 1;
            } else{
                winner = 0;
            }
            PlayerPrefs.SetInt("winnerSTR",winner);
            SceneManager.LoadScene("Victory");
        }
        ResetPosition();
    }
    private void ResetPosition(){
        ball.GetComponent<Ball>().ResetBall();
    }
}
