using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_rb : MonoBehaviour
{
    // Variables
    public float forceAmt = 10f;

    private Rigidbody2D rb;

    private Color defaultColor = Color.blue;

    private bool sceneChanged = false;


    // Start is called before the first frame update
    void Start()
    {
        // Find the rigid body on the object this script is on
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //If statement to move right onscreen by using 'd'
        if (Input.GetKey(KeyCode.D))
        {
            //Make the rigidbody move right
            rb.AddForce(Vector2.right * forceAmt);
        }

        //If statement to move left onscreen by using 'a'
        if (Input.GetKey(KeyCode.A))
        {
            //Make the rigidbody move right
            rb.AddForce(Vector2.left * forceAmt);
        }

        //If statement to jump onscreen by using 'w'
        if (Input.GetKey(KeyCode.W))
        {
            //make the rigidbody fly up
            rb.AddForce(Vector2.up * forceAmt);
        }

        //If statement to jump onscreen by using 'w'
        if (Input.GetKey(KeyCode.S))
        {
            //make the rigidbody move down
            rb.AddForce(Vector2.down * forceAmt);
        }


    }

    //OnCollisionEnter2d happens when two 2D objects with colliders hit each other.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Make the Cube change color when it hits player 2 cube.
       
        if (GameManager.instance.sceneChanged == false)
        {
            GameManager.instance.sceneChanged = true;
            GameManager.instance.ChangeScene();
        }
       
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = defaultColor;
    }
}
