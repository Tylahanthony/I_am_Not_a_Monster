using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour {
    public UnityEngine.UI.Button Button1;
    public UnityEngine.UI.Button Button2;
    // Use this for initialization
    void Start () {
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
            SceneManager.LoadScene("Eileen_Scene", LoadSceneMode.Single);
           }
        if (this.gameObject.name == "creditsButton")
        {

            SceneManager.LoadScene("Credits", LoadSceneMode.Single);
        }
        if (this.gameObject.name == "menuButton")
        {

            SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
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
