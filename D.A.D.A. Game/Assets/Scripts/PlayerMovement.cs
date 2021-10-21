using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed; 
    public bool isGrounded;
    public float jumpVelocity;

    public GameObject bulletLeftPrefab;
    public GameObject bulletRightPrefab;
    public Transform shootPoint;

    private bool dirForward;

    private void Awake()
    {
        //rb = transform.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();

        RotationAndShoot();

        Jump();
    }

    // PlayerMovement
    private void Move()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            transform.rotation = Quaternion.LookRotation(Vector3.back);
            dirForward = false;
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
            transform.rotation = Quaternion.LookRotation(Vector3.forward);
            dirForward = true;
        }
        
    }
    
    // Player Rotate and Shoot in Direction
    private void RotationAndShoot()
    {
        if (Input.GetMouseButtonDown(0) && dirForward == false)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            Debug.Log("Shot left");
            GameObject newLeftBullet = Instantiate(bulletLeftPrefab);
            newLeftBullet.transform.position = shootPoint.transform.position;
            Destroy(newLeftBullet, 2);

           
        }

        if (Input.GetMouseButtonDown(0) && dirForward == true)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            Debug.Log("Shot right");
            GameObject newRightBullet = Instantiate(bulletRightPrefab);
            newRightBullet.transform.position = shootPoint.transform.position;
            Destroy(newRightBullet, 2);
        }
    }

    // Player jumps
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true || Input.GetKey(KeyCode.Joystick1Button1) && isGrounded == true)
        {

            rb.velocity = Vector2.up *jumpVelocity;
            
            isGrounded = false;
        }
    }
    
    // Get a message if player colldide with Objects and set bool isGrounded true
    private void OnCollisionEnter2D(Collision2D collision)
    { 
            Debug.Log("Player collision with" + collision.transform.name);
           isGrounded = true;
    }
    
}