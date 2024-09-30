using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour{
    private Rigidbody2D _rb;
    public float speed=5;
    private Vector3 _startPosition;
    void Start(){       
        _rb = this.GetComponent<Rigidbody2D>();
        _startPosition = transform.position; // Memorizza le coordinate iniziali
        Throwball();
    }
    private void Throwball(){
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        _rb.velocity = new Vector2(speed * x, speed * y);
    }
    public void ResetBall(){
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition; // rimetto la pallina nella posizione iniziale
        Throwball();
    }

    public AudioSource speaker;
    public AudioClip media;
    private void OnCollisionEnter2D(Collision2D col){
        speaker.PlayOneShot(media);
    }
}

