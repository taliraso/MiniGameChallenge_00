using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Dictionary<KeyCode, Command> _keyCommandMapping = new Dictionary<KeyCode, Command>();
    
    public InputHandler(PlayerMovement player)
    {
        _keyCommandMapping.Add(KeyCode.W, new MoveUpCommand(player));
        _keyCommandMapping.Add(KeyCode.A, new MoveLeftCommand(player));
        _keyCommandMapping.Add(KeyCode.S, new MoveDownCommand(player));
        _keyCommandMapping.Add(KeyCode.D, new MoveRightCommand(player));
    }

    public void HandleInput()
    {
        foreach (KeyCode key in _keyCommandMapping.Keys)
        {
            if (Input.GetKey(key))
            {
                _keyCommandMapping[key].Execute();
            }
        }
    }
   
}
