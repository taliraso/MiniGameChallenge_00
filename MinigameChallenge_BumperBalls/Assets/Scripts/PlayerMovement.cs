using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] Rigidbody playerRB;
    [SerializeField] GameObject character;
    Component animator;
    public float forceMultiplier = 20f;



    InputHandler _inputHandler;
    void Start()
    {
        _inputHandler = new InputHandler(this);
        animator = character.GetComponent<Animator>();
    }

    public void MoveUp()
    {
        playerRB.AddForce(Vector3.forward * forceMultiplier);
    }
    public void MoveDown()
    {
        playerRB.AddForce(-Vector3.forward * forceMultiplier);
    }

    public void MoveLeft()
    {
        playerRB.AddForce(Vector3.left * forceMultiplier);
    }
    public void MoveRight()
    {
        playerRB.AddForce(-Vector3.left * forceMultiplier);
    }

    void Update()
    {
        _inputHandler.HandleInput();

    }


}

