using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text;

public class buttonManager : MonoBehaviour {
    public UnityEngine.UI.Button Button1;
    public UnityEngine.UI.Button Button2;
    public UnityEngine.UI.InputField field;
    public GameObject errorText;
    // Use this for initialization
    void Start () {
       // errorText = GameObject.Find("errorText");
      errorText.SetActive(false);
        Button1.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
       // Output this to console when the Button is clicked
      // Debug.Log("You have clicked the button!");
        Debug.Log (this.gameObject.name);
        if (this.gameObject.name == "Retry" || this.gameObject.name == "playButton")
        {
            if (this.gameObject.name == "playButton")
            {
                stats.Speed = float.Parse(field.text);
            }

                if (stats.Speed <= 0)
            {
                errorText.SetActive(true);
                

            }
            else
            {
                SceneManager.LoadScene("Eileen_Scene", LoadSceneMode.Single);
            }


        }
        if (this.gameObject.name == "creditsButton")
        {

            SceneManager.LoadScene("credits", LoadSceneMode.Single);
        }
        if (this.gameObject.name == "htpButton")
        {
            SceneManager.LoadScene("howtoplay", LoadSceneMode.Single);

        }
        if (this.gameObject.name == "menuButton")
        {

            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        if (this.gameObject.name == "tutorialButton")
        {

            SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
        }
        if (this.gameObject.name == "pauseButton")
        {
            //pauseControl();
        }
    }
}
