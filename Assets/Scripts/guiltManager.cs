using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class guiltManager : MonoBehaviour {
    public int guilt;
    public Text guiltText;
    public Image guiltImage;
    public Sprite guiltHalf;
    public Sprite guiltFull;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        guiltText.text = "Guilt: " + guilt; 
        if (guilt >= 50)
        {
            guiltImage.sprite = guiltHalf;

        }
        //guiltImage.
	}
    public void addGuilt(int value)
    {
        guilt += value;

    }

}
