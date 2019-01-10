using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendlyManager : MonoBehaviour
{
    public Sprite[] friends;
    private SpriteRenderer spriteRenderer;
    private int randomNum;
    private BoxCollider2D bCollider;
    //public int bx;
    //public int by;
    private guiltManager guilt;
    private Animator myAnimator;
    // Use this for initialization
    void Start()
    { 
        // Set the new box collider size to a value based on the specific sprite.


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        myAnimator = GetComponent<Animator>();

        myAnimator.SetBool("clicked", false);
        gameObject.SetActive(true);

        guilt = FindObjectOfType<guiltManager>();
        bCollider = GetComponent<BoxCollider2D>();      // Get the box collider.
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the enemy's Sprite Renderer.
        myAnimator = GetComponent<Animator>();
      /*  randomNum = UnityEngine.Random.Range(0, 8); // Generate a random number to use choose enemy type.
        spriteRenderer.sprite = friends[randomNum]; // set the sprite to a random one from the sprite array.
        if (randomNum == 0)
        {

            bCollider.size = new Vector2(16.86095f, 12.29283f);
            bCollider.offset = new Vector2(0.0f, -1.6f);
        }
        if (randomNum == 1)
        {
            bCollider.size = new Vector2(11.18802f, 15.19523f);
            bCollider.offset = new Vector2(0.4f, 0f);
        }
        if (randomNum == 2)
        {
            bCollider.size = new Vector2(7.342396f, 17.11943f);

        }
        if (randomNum == 3)
        {
            bCollider.size = new Vector2(13.64504f, 16.64605f);
            //   bCollider.offset = new Vector2(-1.5f, 0.1056318f);

        }
        if (randomNum == 4)
        {
            bCollider.size = new Vector2(7.445841f, 17.65725f);
            //  bCollider.offset = new Vector2(0.6f, 0.1056318f);


        }
        if (randomNum == 5)
        {
            bCollider.size = new Vector2(11.74502f, 18.45415f);
            //bCollider.offset = new Vector2(0.6f, 0.1056318f);


        }
        if (randomNum == 6)
        {
            bCollider.size = new Vector2(8.424274f, 17.57777f);
            bCollider.offset = new Vector2(0.4f, -0.5f);


        }
        if (randomNum == 7)
        {
            bCollider.size = new Vector2(11.14986f, 18.50517f);
            bCollider.offset = new Vector2(-1f, 0.1056318f);


        }*/

    }
    private void OnMouseDown()
    {
        StartCoroutine(Die());
    }
    IEnumerator Die()
    {
        
        myAnimator.SetBool("clicked", true);
        //Debug.Log("hi");
       
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        guilt.addGuilt(5);

    }
}
