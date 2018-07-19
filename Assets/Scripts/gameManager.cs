using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnEnemy", 2.0f, Random.Range(4, 6));
        InvokeRepeating("spawnFriendly", 2.0f, Random.Range(2, 4));
    }

    // Update is called once per frame
    void Update () {
		
	}
    void spawnEnemy ()
    {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Random.Range(28, 75)));

        GameObject enemy = ObjectPooler.SharedInstance.GetPooledObject("Enemy");
        enemy.transform.position = screenPosition;
        enemy.SetActive(true);

    }

    void spawnFriendly()
    {
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), Random.Range(28, 75)));

        GameObject friendly = ObjectPooler.SharedInstance.GetPooledObject("Friendly");
        friendly.transform.position = screenPosition;
        friendly.SetActive(true);

    }
}
