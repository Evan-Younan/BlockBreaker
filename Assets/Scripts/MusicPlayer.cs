using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer mPlayer = null;

    private void Awake() {
        if (mPlayer != null) {
            Destroy(gameObject);
        }
        else {
            mPlayer = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
