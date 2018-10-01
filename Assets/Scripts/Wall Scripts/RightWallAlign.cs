using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallAlign : MonoBehaviour {


    // Use this for initialization
    void Start () {
        float screenHeight = 9.0f;

        float screenAspect = (float)Screen.width / (float)Screen.height;

        float screenWidth = screenHeight * screenAspect;

        gameObject.transform.position = new Vector3(5.5f + (screenWidth/2)+1.0f, 4.14f, 0.0f);
    }
	
	
}
