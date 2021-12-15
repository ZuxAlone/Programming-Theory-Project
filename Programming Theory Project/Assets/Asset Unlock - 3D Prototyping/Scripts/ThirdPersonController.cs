using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    private float initSpeed = 5.0f;
    private float playerSpeed = 5.0f;
    private float frontLimit = -13.0f;
    
    private CharacterController m_Controller;
    private Animator m_Animator;
    private Vector3 playerVelocity;
    private Vector3 input;
    private bool groundedPlayer;

    private void Start()
    {
        m_Controller = gameObject.GetComponent<CharacterController>();
        m_Animator = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // ABSTRACTION
        Run();
        MovePlayer();
        CheckForBoundries();
        CheckForGroundedPlayer();
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = initSpeed * 2;
        }
        else
        {
            playerSpeed = initSpeed;
        }
    }

    void MovePlayer()
    {
        Vector3 move = input;
        move.y = 0;

        m_Controller.Move(move * Time.deltaTime * playerSpeed);

        m_Animator.SetFloat("MovementX", input.x);
        m_Animator.SetFloat("MovementZ", input.z);
    }

    void CheckForBoundries()
    {
        Vector3 pos = transform.position;
        if (pos.z > frontLimit)
        {
            transform.position = new Vector3(pos.x, pos.y, frontLimit);
        }
    }

    void CheckForGroundedPlayer()
    {
        groundedPlayer = m_Controller.isGrounded;

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = -0.5f;
        }
    }
}
