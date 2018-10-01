using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {


    public int maxHits;

    SpriteRenderer sRenderer;

	// Use this for initialization
	void Start () {
        sRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        maxHits--;

        switch (maxHits) {

            case 1:
                sRenderer.color = new Color32(95, 151, 217, 255);
                break;
            case 2:
                sRenderer.color = new Color32(197, 53, 53, 255);
                break;
            case 3:
                sRenderer.color = new Color32(178, 68, 156, 255);
                break;
        }

        if (maxHits == 0) {
            Destroy(gameObject);
        }
    }
}
