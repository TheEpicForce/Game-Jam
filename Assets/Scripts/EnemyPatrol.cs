using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float moveSpeed;
    public bool moveRight;
    public Rigidbody2D RGBD2;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatisWall;
    private bool hittingWall;

    private bool notAtEdge;
    public Transform edgeCheck;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatisWall);

        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatisWall);

        if (hittingWall || !notAtEdge) 
            moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            RGBD2.velocity = new Vector2(moveSpeed, RGBD2.velocity.y);
        }    else {
            transform.localScale = new Vector3(1f, 1f, 1f);
            RGBD2.velocity = new Vector2(-moveSpeed, RGBD2.velocity.y);
        }
    }
}
