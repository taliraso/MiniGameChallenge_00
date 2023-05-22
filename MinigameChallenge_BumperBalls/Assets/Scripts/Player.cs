using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public class PlayerMovement : Player
    {
        public void ForwardMove()
        {
            rb.AddForce(Vector3.forward, ForceMode.Impulse);
        }
        public void BackMove()
        {
            rb.AddForce(-Vector3.forward, ForceMode.Impulse);
        }
        public void RightMove()
        {
            rb.AddForce(-Vector3.left, ForceMode.Impulse);
        }

        public void LeftMove()
        {
            rb.AddForce(Vector3.left, ForceMode.Impulse);
        }
    }


}
