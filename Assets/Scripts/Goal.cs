using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour{
    public bool isLeft;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Player")){
            gameManager.GetComponent<GameMan>().Goal(isLeft);
        }
    }
}
