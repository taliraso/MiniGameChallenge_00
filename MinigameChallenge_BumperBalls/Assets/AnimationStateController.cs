using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    GameObject gameObject;


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

        if (!isForward && forwardPressed)
        {
            animator.SetBool("isForward", true);
        }

        if (isForward && !forwardPressed)
        {
            animator.SetBool("isForward", false);
        }

        if (!isBackward && backwardPressed)
        {
            animator.SetBool("isBackward", true);
        }

        if (isBackward && !backwardPressed)
        {
            animator.SetBool("isBackward", false);
        }

        if (Input.GetKey("a"))
        {
            gameObject.transform.localRotation()
        }
    }

}
