using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movSpeed;  // Movement speed
    float speedX, speedY;
    Rigidbody2D rb;

    public BallManager bm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;

        Vector2 movement = new Vector2(speedX, speedY).normalized;

        rb.velocity = movement * movSpeed;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            bm.ballCount++;  
            Destroy(other.gameObject);  
        }
    }
}