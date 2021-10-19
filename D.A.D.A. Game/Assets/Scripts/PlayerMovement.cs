using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    
    public float speed;
    public Rigidbody2D rb;
    
    
    
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        rb.MovePosition(rb.position += new Vector2(x, 0) * speed * Time.deltaTime);

    }


}