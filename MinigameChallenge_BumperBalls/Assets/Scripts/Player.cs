using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody playerRB;

    public class PlayerMovement : Player
    {
        public void ForwardMove()
        {
            playerRB.AddForce(Vector3.forward, ForceMode.Impulse);
        }
        public void BackMove()
        {
            playerRB.AddForce(-Vector3.forward, ForceMode.Impulse);
        }
        public void RightMove()
        {
            playerRB.AddForce(-Vector3.left, ForceMode.Impulse);
        }

        public void LeftMove()
        {
            playerRB.AddForce(Vector3.left, ForceMode.Impulse);
        }
    }


}
