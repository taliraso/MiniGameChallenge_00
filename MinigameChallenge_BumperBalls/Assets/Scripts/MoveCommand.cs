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
        Debug.Log("Testing Forward");
    }
}

public class MoveBack : MoveCommand
{
    public override void Execute()
    {
        Debug.Log("Testing Back");
    }
}

public class MoveLeft : MoveCommand
{
    public override void Execute()
    {
        Debug.Log("Testing Left");
    }
}

public class MoveRight : MoveCommand
{
    public override void Execute()
    {
        Debug.Log("Testing Right");
    }
}

public class DoNothing : MoveCommand
{
    public override void Execute()
    {
        Debug.Log("Testing Nothing");
    }
}