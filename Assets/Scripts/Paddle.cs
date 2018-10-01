using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


    private Vector3 curPosition;
    private float screenAspect;
    private float screenHeight;
    private float screenWidth;
    private int screenClamp;

    private void Start()
    {
        screenHeight = 9.0f;
     //   print(Screen.height);
      //  print(Screen.width);
        screenAspect = (float)Screen.width / (float)Screen.height;
        screenWidth = screenHeight * screenAspect;

       // print(screenAspect);

      //  print(screenWidth);

    }
    // Update is called once per frame
    void Update () {
        

        curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curPosition.x = Mathf.Clamp(curPosition.x, 6.0f-(screenWidth/2), 5.0f + (screenWidth / 2));
        curPosition.y = 1.0f;
        curPosition.z = 0.0f;
        this.transform.position = curPosition;

    }
}
