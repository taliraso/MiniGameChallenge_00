using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    private Vector3 _direction;
    public Vector3 playerDirection;
    [SerializeField] GameObject ball;
    public float playerY = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        bool isForward = animator.GetBool("isForward");
        bool isBackward = animator.GetBool("isBackward");
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");

        gameObject.transform.position = ball.transform.position + new Vector3(0, playerY, 0);

        PlayerAnimationStates(isForward, isBackward, forwardPressed, backwardPressed);
        TurnPlayer();
    }

    void PlayerAnimationStates(bool isForward, bool isBackward, bool forwardPressed, bool backwardPressed)
    {
        if (!isForward && forwardPressed)
        {
            animator.SetBool("isForward", true);
        }

        if (isForward && !forwardPressed)
        {
            animator.SetBool("isForward", false);
        }


    }

    void TurnPlayer()
    {

        playerDirection = gameObject.transform.position;
        _direction = new Vector3(playerDirection.x, 0.0f, playerDirection.z);

        var targetAngle = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, targetAngle, 0.0f);
    }

}
