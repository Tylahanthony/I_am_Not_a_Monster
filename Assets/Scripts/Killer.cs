using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private Camera mainCamera;

    public Renderer myRenderer;
    // Use this for initialization
    void Start()
    {

    myRenderer = GetComponent<Renderer>();
        mainCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z < mainCamera.transform.position.z)
        {
            Debug.Log("Testing");
            Destroy(gameObject);
        }

    }
    

}
    