using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpCommand : ICommand
{
    private PlayerMovement _player;

    public MoveUpCommand(PlayerMovement player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.MoveUp();
    }
}

public class MoveDownCommand : ICommand
{
    private PlayerMovement _player;

    public MoveDownCommand(PlayerMovement player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.MoveDown();
    }
}