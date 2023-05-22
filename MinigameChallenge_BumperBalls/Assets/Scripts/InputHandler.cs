using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    //[SerializeField] GameObject player;
    //private Rigidbody rb;

    private ICommand keyW, keyA, keyS, keyD, nothing;


    private void Start()
    {
        //rb = player.GetComponent<Rigidbody>();

        keyW = new MoveCommand.MoveForward();
        keyA = new MoveCommand.MoveLeft();
        keyS = new MoveCommand.MoveBack();
        keyD = new MoveCommand.MoveRight();
        nothing = new MoveCommand.DoNothing();

    }
    void Update()
    {
        Moving();
    }


    void Moving()
    {
        if (Input.GetKey(KeyCode.W))
        {
            keyW.Execute();
            Debug.Log("move forward");
        }
        if (Input.GetKey(KeyCode.A))
        {
            keyA.Execute();
            Debug.Log("move left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            keyS.Execute();
            Debug.Log("move back");
        }
        if (Input.GetKey(KeyCode.D))
        {
            keyD.Execute();
            Debug.Log("move right");
        }
        else Stationary();
    }

    void Stationary()
    {
        nothing.Execute();

        Debug.Log("Stationary");
    }

}