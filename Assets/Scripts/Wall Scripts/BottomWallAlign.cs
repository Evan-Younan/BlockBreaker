using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallAlign : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float screenHeight = 9.0f;
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float screenWidth = screenHeight * screenAspect;

        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(screenWidth, 2.0f);
    }
}
