using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveCommand
{
    public abstract void Execute();

}

public class MoveForward : MoveCommand
{
    public override void Execute()
    {
        Debug.Log("Testing");
        //rb.AddForce(Vector3(0f, 0f, 3f), ForceMode.Force);
    }
}

public class MoveBack : MoveCommand
{
    public override void Execute()
    {
        //rb.AddForce(-Vector3(0f, 0f, 3f), ForceMode.Force);
    }
}

public class MoveLeft : MoveCommand
{
    public override void Execute()
    {
        //rb.AddForce(Vector3(3f, 0f, 0f), ForceMode.Force);
    }
}

public class MoveRight : MoveCommand
{
    public override void Execute()
    {
        //rb.AddForce(Vector3(3f, 0f, 0f), ForceMode.Force);
    }
}

public class DoNothing : MoveCommand
{
    public override void Execute()
    {
        //Nothing will happen if we press this key
    }
}