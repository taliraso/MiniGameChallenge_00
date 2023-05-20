using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Rigidbody rb; 

    private void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }
    void Update()
    {
        Move();
    }


    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
            //MoveForward.Execute();
            Debug.Log("move forward");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left, ForceMode.Impulse);
            Debug.Log("move left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward, ForceMode.Impulse);
            Debug.Log("move back");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-Vector3.left, ForceMode.Impulse);
            Debug.Log("move right");
        }
        else Stationary();
    }

    void Stationary()
    {
        Debug.Log("Stationary");
    }

}