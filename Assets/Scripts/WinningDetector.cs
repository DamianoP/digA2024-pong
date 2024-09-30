using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningDetector : MonoBehaviour
{
    // Questo script aggiorna la stringa scrivendo chi ha vinto la partita
    void Start(){
        string winner = "";
        int whoWin = PlayerPrefs.GetInt("winnerSTR");
        if (whoWin == 1){
            winner = "PLAYER 1 WIN";
        } else{
            winner = "CPU WIN";
        }
        PlayerPrefs.DeleteKey("winnerSTR");
        this.GetComponent<TextMeshProUGUI>().text = winner;
        StartCoroutine(Delay(5.0f));
    }
    IEnumerator Delay(float delay){
        yield return new WaitForSeconds(delay);
        RestartGame();
    }
    private void RestartGame(){
        SceneManager.LoadScene("SampleScene");
    }
    /*
    private float _timer=0.0f;
    public void Update(){
        _timer += Time.deltaTime;
        if (_timer > 5.0f){ RestartGame(); }
    }
    */

}
