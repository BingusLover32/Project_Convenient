using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Assuming the Animator component is attached to the same GameObject
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("PlayerURight");
            }
            else
            {
                animator.Play("PlayerUp");
            }

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.Play("PlayerURight");
            }
            else
            {
                animator.Play("PlayerRight");
            };
        }

        if (Input.GetKeyDown(KeyCode.S))

        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.Play("PlayerDRight");
            }
            else
            {
                animator.Play("PlayerDown");
            };
        }
        if (Input.GetKeyDown(KeyCode.A))

        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.Play("PlayerDRight");
            }
            else
            {
                animator.Play("PlayerRight");
            };
        }
    }
}