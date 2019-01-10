using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    public GameObject[] levels;
    public guiltManager guilt;
    private Camera mainCamera;

    
    // Use this for initialization
    void Start () {
        //spawnBlocks();
        // InvokeRepeating("spawnEnemy", 2.0f, Random.Range(4, 6));
        //InvokeRepeating("spawnFriendly", 2.0f, Random.Range(2, 4));
       
        spawnBlocks();
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update () {
        //   Debug.Log(UnityEngine.Random.Range(0, 6));
       // Debug.Log("Current Guilt: " + guilt.guilt);
        if (guilt.guilt >= 100)
        {
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single);


        }
        if (mainCamera.transform.position.z >= 265)
        {
            SceneManager.LoadScene("winGame", LoadSceneMode.Single);

        }
    }
    void spawnBlocks()
    {
        for (int i = 0; i < 15; i++)
        {
            int random = UnityEngine.Random.Range(0, 10);
          //  Debug.Log("Random Value:" + random);
           //Debug.Log("x position" + levels[random].transform.position.x);
            //Debug.Log("y levels" +levels[random].transform.position.y);
            //Debug.Log("Z Size:" + -117.2f + (28.35f * i));
            Instantiate(levels[random], new Vector3(levels[random].transform.position.x, levels[random].transform.position.y, -117.2f + (28.35f * i)), Quaternion.identity);

           
            
        }

        
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
