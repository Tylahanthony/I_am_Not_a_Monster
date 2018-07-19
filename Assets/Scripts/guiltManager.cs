using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class guiltManager : MonoBehaviour {
    public int guilt;
    public Text guiltText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        guiltText.text = "Guilt: " + guilt; 
	}
    public void addGuilt(int value)
    {
        guilt += value;

    }

}
