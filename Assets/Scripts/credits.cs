using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < 825)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
        }  
            }
}
