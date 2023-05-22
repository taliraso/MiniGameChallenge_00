using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : MonoBehaviour
{
    public class MoveForward : ICommand
    {
        public void Execute()
        {
            //instantiate the player movement class 
            //Player.PlayerMovement pm = new Player.PlayerMovement();
            //Call the function off that class
            //pm.ForwardMove();
            Debug.Log("Testing Forward");
        }
    }

    public class MoveBack : ICommand
    {
        public void Execute()
        {
            //Player.PlayerMovement pm = new Player.PlayerMovement();
            //pm.BackMove();
            Debug.Log("Testing Back");
        }
    }

    public class MoveLeft : ICommand
    {
        public void Execute()
        {
            //Player.PlayerMovement pm = new Player.PlayerMovement();
            //pm.LeftMove();
            Debug.Log("Testing Left");
        }
    }

    public class MoveRight : ICommand
    {
        public void Execute()
        {
            //Player.PlayerMovement pm = new Player.PlayerMovement();
            //pm.RightMove();
            Debug.Log("Testing Right");
        }
    }

    public class DoNothing : ICommand
    {
        public void Execute()
        {
            Debug.Log("Testing Nothing");
        }
    }
}
