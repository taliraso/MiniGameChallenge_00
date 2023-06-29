using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute();
}

public class MoveUpCommand : Command
{
    private PlayerMovement _player;

    public MoveUpCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveUp();
    }
}

public class MoveDownCommand : Command
{
    private PlayerMovement _player;

    public MoveDownCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveDown();
    }
}

public class MoveLeftCommand : Command
{
    private PlayerMovement _player;

    public MoveLeftCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveLeft();
    }
}

public class MoveRightCommand : Command
{
    private PlayerMovement _player;

    public MoveRightCommand(PlayerMovement player)
    {
        _player = player;
    }

    public override void Execute()
    {
        _player.MoveRight();
    }
}