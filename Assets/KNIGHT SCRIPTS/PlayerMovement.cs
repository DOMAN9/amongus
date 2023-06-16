using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    //speed
    public float moveSpeed;

    //rigid body(makes it move)
    public Rigidbody2D rigidBody;
    // where the playe is moving
    private Vector2 movementInput;
    //Access animator to play animation
    public Animator anim;

    //START///////////////////////////////////////////////////////////////////////////////////////
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //UPDATES///////////////////////////////////////////////////////////////////////////////////////
    // Update is called once per frame
    void Update()
    {
        
    }
    //fixed updates for calculating physics
    private void FixUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;//makes player move
    }

    //MOVEMENT//////////////////////////////////////////////////////////////////////////////////////
    //input system click
    private void OnMove(InputValue inputValue)
    {
        //if press wasd is converted to vector 2 values
        movementInput = inputValue.Get<Vector2>();
    }
}
