using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject StipStep;
    public GameObject StiperSteper;
    public CharacterController controller;

    public GunAnimations GA;
    public Melee_Attack MA;
    public GunGunBangBang GGBB;

    public float currentSpeed = 12f;
    public float gravity = -9.81f;
    public float currentJumpHight = 4f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public GameObject PlayerIdle;

    public bool IsWalkingHorizontal;
    public bool IsWalkingVertical;

    public Animator IdleAnimator;

    public AttackHurt attackHurt;
    public GunAnimations Gun;

    public Animator attackHurt1Animator;
    public Animator Gun1Animator;

    public GameObject CameraTransform;
    public GameObject AnimationCameraTransform;

    public GameObject NewCrouchingCameraPos;
    public GameObject NewRunningCameraPos;
    public GameObject NewWalkingCameraPos;

    public bool isRunning = false;
    public bool isWalking = true;
    public bool isCrouching = false;

    public float crouchSpeed = 6f;
    public float walkingSpeed = 12f;
    public float runningSpeed = 24f;
    public float normalJumpHight = 4f;
    public float crouchJumpHight = 5.5f;


    Vector3 velocity;

    Vector3 CrouchingCameraPos;
    Vector3 RunningCameraPos;
    Vector3 WalkingCameraPos;

    bool CallingIdleVoid = false;
    bool CallingWalkingVoid = false;
    bool CallingCrouchingVoid = false;
    bool CallingRunningVoid = false;

    bool isGrounded;


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        if (x != 0)
        {
            IsWalkingHorizontal = true;
        }
        else
        {
            IsWalkingHorizontal = false;
        }

        if (z != 0)
        {
            IsWalkingVertical = true;
        }
        else
        {
            IsWalkingVertical = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
            isWalking = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
            isWalking = true;

        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouching = false;
            isWalking = true;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            isCrouching = true;
            isWalking = false;
        }


        Vector3 CrouchingCameraPos = NewCrouchingCameraPos.transform.position;
        Vector3 RunningCameraPos = NewRunningCameraPos.transform.position;
        Vector3 WalkingCameraPos = NewWalkingCameraPos.transform.position;


        if (isCrouching)
        {
            Crouching();
            CameraTransform.transform.position = CrouchingCameraPos;
            AnimationCameraTransform.transform.position = CrouchingCameraPos;
            StipStep.SetActive(false);
            StiperSteper.SetActive(false);
            GA.enabled = true;   //
            MA.enabled = true;
            GGBB.enabled = true;   //
            if (Gun.IsInAnimation == true)
            {
                Gun1Animator.SetTrigger("WasInAnimation");
            }
            if (attackHurt.IsInAnimation == true)
            {
                attackHurt1Animator.SetTrigger("WasInAnimation");
            }
        }

        if (isRunning && IsWalkingHorizontal)
        {
            Running();
            CameraTransform.transform.position = RunningCameraPos;
            AnimationCameraTransform.transform.position = RunningCameraPos;
            StipStep.SetActive(false);
            StiperSteper.SetActive(true);
            GA.enabled = false;
            MA.enabled = false;
            GGBB.enabled = false;
            if (Gun.IsInAnimation == true)
            {
                Gun1Animator.SetTrigger("WasInAnimation");
            }
            if (attackHurt.IsInAnimation == true)
            {
                attackHurt1Animator.SetTrigger("WasInAnimation");
            }
            PlayerIdle.transform.localRotation = Quaternion.Euler(-90f, x * 45f, 0f);
        }
        if (isRunning && IsWalkingVertical)
        {
            Running();
            CameraTransform.transform.position = RunningCameraPos;
            AnimationCameraTransform.transform.position = RunningCameraPos;
            StipStep.SetActive(false);
            StiperSteper.SetActive(true);
            GA.enabled = false;
            MA.enabled = false;
            GGBB.enabled = false;
            if (Gun.IsInAnimation == true)
            {
                Gun1Animator.SetTrigger("WasInAnimation");
            }
            if (attackHurt.IsInAnimation == true)
            {
                attackHurt1Animator.SetTrigger("WasInAnimation");
            }
        }
        if (isWalking && IsWalkingHorizontal)
        {
            Walking();
            CameraTransform.transform.position = WalkingCameraPos;
            AnimationCameraTransform.transform.position = WalkingCameraPos;
            PlayerIdle.transform.localRotation = Quaternion.Euler(-90f, x * 15f, 0f);
            StipStep.SetActive(true);
            StiperSteper.SetActive(false);
            GA.enabled = true;
            MA.enabled = true;
            GGBB.enabled = true;
            if (Gun.IsInAnimation == true)
            {
                Gun1Animator.SetTrigger("WasInAnimation");
            }
            if (attackHurt.IsInAnimation == true)
            {
                attackHurt1Animator.SetTrigger("WasInAnimation");
            }

        }
        if (isWalking && IsWalkingVertical)
        {
            Walking();
            CameraTransform.transform.position = WalkingCameraPos;
            AnimationCameraTransform.transform.position = WalkingCameraPos;
            StipStep.SetActive(true);
            StiperSteper.SetActive(false);
            GA.enabled = true;
            MA.enabled = true;
            GGBB.enabled = true;
            if (Gun.IsInAnimation == true)
            {
                Gun1Animator.SetTrigger("WasInAnimation");
            }
            if (attackHurt.IsInAnimation == true)
            {
                attackHurt1Animator.SetTrigger("WasInAnimation");
            }
        }

        if (IsWalkingVertical == false && IsWalkingHorizontal == false && isCrouching == false)
        {
            Idle();
            StiperSteper.SetActive(false);
            CameraTransform.transform.position = WalkingCameraPos;
            AnimationCameraTransform.transform.position = WalkingCameraPos;
            StipStep.SetActive(false);
            GA.enabled = true;
            MA.enabled = true;
            GGBB.enabled = true;
            CallingIdleVoid = true;
        }
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        if (isRunning && isGrounded && z > -1)
        {
            currentSpeed = runningSpeed;
            currentJumpHight = normalJumpHight;
        }
        if (isRunning && isGrounded && z <= -1)
        {
            currentSpeed = walkingSpeed;
            currentJumpHight = normalJumpHight;
        }
        if (isWalking && isGrounded)
        {
            currentSpeed = walkingSpeed;
            currentJumpHight = normalJumpHight;
        }
        if (isCrouching && isGrounded)
        {
            currentSpeed = crouchSpeed;
            currentJumpHight = crouchJumpHight;
        }

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * currentSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(currentJumpHight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    void Idle ()
    {
        if (CallingIdleVoid == false)
        {
            IdleAnimator.SetTrigger("IsIdle");
            CallingIdleVoid = true;
            CallingRunningVoid = false;
            CallingCrouchingVoid = false;
            CallingWalkingVoid = false;
        }
    }
    void Walking ()
    {
        if (CallingWalkingVoid == false)
        {
            IdleAnimator.SetBool("IsWalking", true);
            IdleAnimator.SetBool("IsRunning", false);
            IdleAnimator.SetBool("IsCrouching", false);
            IdleAnimator.SetBool("IsIdle", false);
            CallingRunningVoid = false;
            CallingCrouchingVoid = false;
            CallingWalkingVoid = true;
            CallingIdleVoid = false;
        }
    }
    void Running ()
    {
        if (CallingRunningVoid == false)
        {
            IdleAnimator.SetBool("IsWalking", false);
            IdleAnimator.SetBool("IsRunning", true);
            IdleAnimator.SetBool("IsCrouching", false);
            IdleAnimator.SetBool("IsIdle", false);
            CallingRunningVoid = true;
            CallingCrouchingVoid = false;
            CallingWalkingVoid = false;
            CallingIdleVoid = false;
        }
    }
    void Crouching ()
    {
        if (CallingCrouchingVoid == false)
        {
            IdleAnimator.SetBool("IsWalking", false);
            IdleAnimator.SetBool("IsRunning", false);
            IdleAnimator.SetBool("IsCrouching", true);
            IdleAnimator.SetBool("IsIdle", false);
            CallingCrouchingVoid = true;
            CallingRunningVoid = false;
            CallingWalkingVoid = false;
            CallingIdleVoid = false;
        }
    }


    public void Die()
    {
        PlayerIdle.SetActive(false);
        this.enabled = false;
    }

}