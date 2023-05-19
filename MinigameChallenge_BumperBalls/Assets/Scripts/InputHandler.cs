using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //MoveForward.Execute();
            Debug.Log("move forward");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("move left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("move back");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("move right");
        }
        else Stationary();
    }

    void Stationary()
    {
        Debug.Log("Stationary");
    }

}