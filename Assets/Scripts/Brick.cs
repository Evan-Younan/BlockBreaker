using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int numHitsLeft;

    private static int bricksLeft;

	// Use this for initialization
	void Start () {
        bricksLeft++;
    }

    public static int BricksLeft
    {
        get { return bricksLeft; }
        set
        {
            bricksLeft = value;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        numHitsLeft--;

        switch (numHitsLeft) {

            case 1:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(95, 151, 217, 255);
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(197, 53, 53, 255);
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(178, 68, 156, 255);
                break;
        }
        
        if (numHitsLeft <= 0) {
            bricksLeft--;
            Destroy(gameObject);
        }
        if (bricksLeft == 0) {
            GameObject.FindObjectOfType<LevelManager>().LoadNextLevel();
        }
    }
}
