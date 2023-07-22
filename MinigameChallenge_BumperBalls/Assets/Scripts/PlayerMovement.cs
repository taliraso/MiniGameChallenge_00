using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    //for movement
    [SerializeField] Rigidbody playerRB;
    public float forceMultiplier = 20f;

    //for animation
    [SerializeField] GameObject character;
    Animator animator;
    public bool isMoving;
    public bool isMove;



    InputHandler _inputHandler;
    void Start()
    {
        _inputHandler = new InputHandler(this);
        animator = character.GetComponent<Animator>();
        animator.GetBool("isMoving");
    }

    public void MoveUp()
    {
        playerRB.AddForce(Vector3.forward * forceMultiplier);
        isMove = true;
    }
    public void MoveDown()
    {
        playerRB.AddForce(-Vector3.forward * forceMultiplier);
        isMove = true;
    }

    public void MoveLeft()
    {
        playerRB.AddForce(Vector3.left * forceMultiplier);
        isMove = true;
    }
    public void MoveRight()
    {
        playerRB.AddForce(-Vector3.left * forceMultiplier);
        isMove = true;
    }

    void Update()
    {
        _inputHandler.HandleInput();


        ChangeAnimation();

        void ChangeAnimation()
        {
            if (isMove == true)
            {
                animator.SetBool("isMoving", true);
            }
            else animator.SetBool("isMoving", false);
        }
    }



}

