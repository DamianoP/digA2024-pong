using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour{
    private Rigidbody2D rb;
    public float speed = 5;
    private float _movement;
    public GameObject ball;
    public bool cpuControl;
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update(){
        if (cpuControl){
            float ballY  = ball.transform.position.y;
            float paddleY = transform.position.y;
            if (ballY > paddleY){ _movement = 1;  } 
            else{                 _movement = -1; }
        } else{
            _movement = Input.GetAxis("Vertical");
        }
        rb.velocity = new Vector2(0, _movement * speed);
    }
}
