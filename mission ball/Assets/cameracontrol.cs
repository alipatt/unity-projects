using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour {
    public GameObject ball;
    Vector3 candb;
	// Use this for initialization
	void Start () {
        candb = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = ball.transform.position + candb;
	}
}
