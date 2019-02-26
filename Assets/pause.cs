using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour {
    public UnityEngine.UI.Button Button1;

    // private int paused = 0;
    public cameraController cc;
    // Use this for initialization
    void Start () {
        Button1.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        if (this.gameObject.name == "pauseButton")
        {
            PauseControl();
        }



    }
    void PauseControl()
    {

        if (stats.Paused == 0)
        {
            cc.cameraSpeed = 0;

        }
        else if (stats.Paused == 1)
        {
            cc.cameraSpeed = stats.Speed;

        }
        stats.Paused = stats.Paused ^ 1;
            Debug.Log(stats.Paused);
        
      


    }
    // Update is called once per frame
    void Update () {
		
	}
}
