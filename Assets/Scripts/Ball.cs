using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;

    private Rigidbody2D ballRigidBody2D;

    private Vector3 paddleToBallVector;
    private bool hasStarted;
    private bool mouseDownFirstTime;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        ballRigidBody2D = GetComponent<Rigidbody2D>();
        hasStarted = false;
        mouseDownFirstTime = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted) {
            if (Input.GetMouseButtonDown(0))
            {
                mouseDownFirstTime = true;
            } else if (mouseDownFirstTime) {
                if (Input.GetMouseButtonUp(0)) {
                    hasStarted = true;
                    ballRigidBody2D.velocity = new Vector2(2.0f, 10.0f);
                }
            }

            this.transform.position = paddle.transform.position + paddleToBallVector;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));
        ballRigidBody2D.velocity += tweak;
    }
}
