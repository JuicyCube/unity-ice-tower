using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public ScoreManager scoreManager;

    public float jumpForce = 90f;
    public float moveForce = 200f;
    public float maxSpeed = 6f;
    public float HorizontalJumpFactor = 90f;
    public float bounceFactor = 1.1f;
    public float forceJumpLimit = 170f;
    public ParticleSystem forceJumpEffect;
    public ParticleSystem moveParticle;
    private Rigidbody2D player;

    private bool facingRight = true;
    private bool jump = false;
    private bool isGrounded;
    private Animator animator;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public bool isGameEnd = false, isGamePause = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    
    {
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        animator.SetBool("Grounded", isGrounded);

        if (Input.GetButtonDown("Jump") && isGrounded)
            jump = true;
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(h));

        if (Mathf.Abs(h * player.velocity.x) < maxSpeed)
            player.AddForce(h * moveForce * Vector2.right);

       if (Mathf.Abs(h) <= 0.05) player.velocity = new Vector2(0, player.velocity.y);
        else if (isGrounded) moveParticle.Play();
        else moveParticle.Stop();

        if ((h > 0 && !facingRight) || (h < 0 && facingRight)) Flip();

        if (jump)
        {
            float totalJumpForce = jumpForce + Mathf.Abs(player.velocity.x) * HorizontalJumpFactor;
            if (totalJumpForce > forceJumpLimit)
                //forceJumpEffect.Play();
            player.AddForce(Vector2.up * totalJumpForce);
            jump = false;
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Trap")
        {
            isGameEnd = true;
        }
        if (collision.gameObject.tag == "Wall")
        {
            Flip();
            Vector2 rev = new Vector2(player.velocity.x * bounceFactor, 0);
            player.AddForce(rev, ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "Platform")
        {
            scoreManager.UpdateScore((int)transform.position.y);
        }



        // playerAnimation.SetFloat("Speed", Mathf.Abs(player.velocity.x));
        // playerAnimation.SetBool("OnGround", isTouchingGround);

        //fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
        /*ool CanMove()
         {
             if (!isGamePause && !isGameEnd)
                 return true;
             return false;
         }*/
    }
}