using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rigidBody2D;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0,directionY).normalized;    
    }
    private void FixedUpdate()
    {
        rigidBody2D.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
