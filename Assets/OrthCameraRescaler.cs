using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthCameraRescaler : MonoBehaviour {


	// Use this for initialization
	void Start () {
     //   Camera.main.orthographicSize = 17.0f * Screen.height / Screen.width * 0.5f;
    }
	
	// Update is called once per frame
	void Update () {

        Mathf.Floor(Camera.main.orthographicSize);
		if (Input.GetMouseButtonDown(1)) {
            Camera.main.orthographicSize = 17.0f * Screen.height / Screen.width * 0.5f;
          //  Camera.main.transform.position = new Vector3(camPos.x, camPos.y-(Camera.main.orthographicSize - Mathf.Floor(
                         //   Camera.main.orthographicSize)), camPos.z);
        }
	}

    
}
