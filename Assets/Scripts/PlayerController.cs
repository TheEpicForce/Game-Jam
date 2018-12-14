using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; 
    public float jumpHeight;
    public Rigidbody2D RGB2D;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatisGround;
    private bool grounded;
     
    private bool doubleJumped;
    private Animator anim;


     // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    private void FixedUpdate()
    
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatisGround);
    }

    // Update is called once per frame
    void Update () {

        if (grounded)
            doubleJumped = false;

        anim.SetBool("Grounded", grounded); 

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            RGB2D.velocity = new Vector2(0, jumpHeight);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            RGB2D.velocity = new Vector2(0, jumpHeight);
            doubleJumped = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            RGB2D.velocity = new Vector2(moveSpeed, RGB2D.velocity.y);
        }

       if (Input.GetKeyDown(KeyCode.A))
        {
            RGB2D.velocity = new Vector2(-moveSpeed, RGB2D.velocity.y);
        }

        anim.SetFloat("Speed", Mathf.Abs (RGB2D.velocity.x));

        if (RGB2D.velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (RGB2D.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
     
    }

    public void Jump ()
    {
        RGB2D.velocity = new Vector2(moveSpeed, RGB2D.velocity.y);
    }
}
