using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {


    private LevelManager lManager;

    private void Start() {
        lManager = GameObject.FindObjectOfType<LevelManager>();
    }
    //Look into Block Breaker (5th Udemy package) under video 72 for more info on triggers and collisions!
    void OnTriggerEnter2D(Collider2D collision) {
        print("Trigger");
        lManager.LoadLevel("Win");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        print("Collision");
    }
}
