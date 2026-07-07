using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
 
public class PlayerMovement : MonoBehaviour

{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float moveX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }

    private void OnMove(InputValue moveValue)
    {
       Vector2 moveDirection = moveValue.Get<Vector2>();
       moveX = moveDirection.x;
    }
    
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if (collision.gameObject.CompareTag("Cube"))
     {
         ScoreManager.instance.AddScore(1);
     }
    }
}

