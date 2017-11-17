using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        float mouseInBlocks = (Input.mousePosition.x / Screen.width * 16) -8;
        Vector3 newPaddlePos = new Vector3(mouseInBlocks, gameObject.transform.position.y, gameObject.transform.position.z);
        newPaddlePos.x = Mathf.Clamp(mouseInBlocks, -7.36f, 7.36f);
        gameObject.transform.position = newPaddlePos;

        
    }
}
