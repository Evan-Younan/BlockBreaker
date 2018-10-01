using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


    private Vector3 curPosition;
    private float screenAspect;
    private float screenHeight;
    private float screenWidth;
    private int screenClamp;

    private bool hasStarted;

    private Ball ball;

    private float valueOffset;

    private void Start()
    {
        screenHeight = 9.0f;
        screenAspect = (float)Screen.width / (float)Screen.height;
        screenWidth = screenHeight * screenAspect;
        valueOffset = Screen.width / 208;

       // hasStarted = false;
      //  ball = GameObject.FindObjectOfType<Ball>();
    }
    // Update is called once per frame
    void Update () {
    /*
          if (hasStarted) {
              curPosition.x = ball.transform.position.x;

          } else if (Input.GetMouseButton(0)) {
              hasStarted = true;
          } else {
              curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
              curPosition.x = Mathf.Clamp(curPosition.x, 6.0f-(screenWidth/2), 5.0f + (screenWidth / 2));
          }
          curPosition.y = 1.0f;
          curPosition.z = 0.0f;
          this.transform.position = curPosition;
         */
        curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curPosition.y = 1.0f;
        curPosition.z = 0.0f;

        curPosition.x = Mathf.Clamp(curPosition.x, 6.5f-(screenWidth/2) , 4.5f + (screenWidth / 2) );
        this.transform.position = curPosition;

    }
}
