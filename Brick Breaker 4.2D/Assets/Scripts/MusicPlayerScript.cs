using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // this current object (my Music Player)
            DontDestroyOnLoad(gameObject);
        }
        else // if not null, then a Music Player is already running
        {
            Destroy(gameObject);
            print("Duplicate Music Player is self destructing!");
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
