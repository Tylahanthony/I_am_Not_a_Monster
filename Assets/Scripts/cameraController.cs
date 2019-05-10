using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    // Use this for initialization
    public float cameraSpeed;
	void Start () {
        stats.Paused = 1;
        cameraSpeed = stats.Speed;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (stats.Paused == 0)
        {
            cameraSpeed = stats.Speed;
        }
        

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + cameraSpeed);
	}
}
