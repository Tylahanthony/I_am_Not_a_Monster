using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour {
    public Sprite[] enemys;
    private SpriteRenderer spriteRenderer;
    private int randomNum;
    private BoxCollider2D bCollider;
    private Animator myAnimator;

    // Use this for initialization
    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnEnable()
    {
        myAnimator = GetComponent<Animator>();

        myAnimator.SetBool("clicked", false);
        gameObject.SetActive(true);
        bCollider = GetComponent<BoxCollider2D>(); // Get the box collider.
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the enemy's Sprite Renderer.

        randomNum = UnityEngine.Random.Range(0, 5); // Generate a random number to use choose enemy type.
        Debug.Log(randomNum);
        spriteRenderer.sprite = enemys[randomNum]; // set the sprite to a random one from the sprite array.
        spriteRenderer.color = new Color(255, 255, 255, 255); 
        if (randomNum == 0)
        {

            bCollider.size = new Vector2(8.904737f, 20.48f);
            bCollider.offset = new Vector2(0.4f, 0.1056318f);
        }
        if (randomNum == 1)
        {
            bCollider.size = new Vector2(8.904737f, 20.48f);
            bCollider.offset = new Vector2(0.5f, 0.1056318f);
        }
        if (randomNum == 2)
        {
            bCollider.size = new Vector2(13.03557f, 19.53205f);

        }
        if (randomNum == 3)
        {
            bCollider.size = new Vector2(16.89617f, 19.32337f);
            bCollider.offset = new Vector2(-1.5f, 0.1056318f);

        }
        if (randomNum == 4)
        {
            bCollider.size = new Vector2(16.57253f, 18.9509f);
            bCollider.offset = new Vector2(0.6f, 0.1056318f);


        } // Set the new box collider size to a value based on the specific sprite.

    }
    private void OnMouseDown()
    {
        StartCoroutine(Die());
    }
    IEnumerator Die()
    {

        myAnimator.SetBool("clicked", true);
        Debug.Log("hi");
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        //Play fadeout animation and deactiavate object.

    }
}
