using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    int count;
    public float tolerance;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal > tolerance)
            moveHorizontal = speed;
        else if (moveHorizontal < -tolerance)
            moveHorizontal = -speed;
        if (moveVertical > tolerance)
            moveVertical = speed;
        else if (moveVertical < -tolerance)
            moveVertical = -speed;
        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);


        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        //rb2d. = new Vector2(0,0);
        rb2d.AddForce(movement);
        rb2d.velocity = movement;
        //rb2d.MovePosition(rb2d.position + movement);
        
        
        
    }
}
