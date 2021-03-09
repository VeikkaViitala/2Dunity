using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 2;
    public Rigidbody2D rb2D;
    private float horizontalMovenment;
    public int facing = 1;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovenment = Input.GetAxis("Horizontal");
        float flipX = Input.GetAxisRaw("Horizontal");
            Walk();


        if (flipX != 0 && canMove == true)
            //flipPlayer(flipX);
        {

        }
    }
    private void FixedUpdate() {
        Walk();
    }
    public void Walk(){
        Vector2 playerVelocity = new Vector2(horizontalMovenment * moveSpeed, rb2D.velocity.y);
        rb2D.velocity = playerVelocity;
    }
    public void flipPlayer(float x) {

        transform.localScale = new Vector2(x, transform.localScale.y);
        facing = (int)x;
        

    }
}