using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
private Rigidbody2D rb; // Det er rigidbody vi vil flytte rundt
private Vector2 movement; // Vi vil gemme det "Vector2" der kommer fra brugeren når de trykker på W, A, S eller D indi movement variablen
[SerializeField]private int speed; // Hastigheden på vores spiller
private Animator playerAnimation; // Vi laver en Animator variable så vi kan pille med den i koden


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
    
    }

private void FixedUpdate()
{
    rb.velocity = movement * speed;
}

    private void OnMovement(InputValue value) // Funktion der holder øje med vores Input Systems value
    {
        movement = value.Get<Vector2>();

        if (movement.x !=0 || movement.y !=0)
        {
        
        playerAnimation.SetFloat("X", movement.x);
        playerAnimation.SetFloat("Y", movement.y);
}


    }
}
