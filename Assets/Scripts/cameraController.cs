using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    // Use this for initialization
    public float cameraSpeed;
	void Start () {
        cameraSpeed = stats.Speed;
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + cameraSpeed);
	}
}
