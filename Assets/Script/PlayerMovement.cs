using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public bool faceingRight;
    void Start()
    {

    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x < 0)//hrac jde do leva
        {
            faceingRight = false;
        }
        if (movement.x > 0)
        {
            faceingRight = true;
        }
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        if (faceingRight)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if (!faceingRight)
        {
            transform.localScale = new Vector2(1, 1);
        }
    }
    
}