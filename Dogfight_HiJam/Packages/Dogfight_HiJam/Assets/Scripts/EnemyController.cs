using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour {

    private Rigidbody myRb;
    

    public float eSpeed;

    public EnemyGunController EGun;
    public EnemyGunController EGun1;

    public float timeBetweenshot;

    private float shotCounter;

    public Transform thePlayer;

    
    //public Transform player;

    // Use this for initialization
    void Start () {

        myRb = GetComponent<Rigidbody>();

        shotCounter = 0.0f;

        //thePlayer = FindObjectOfType<PlayerController>();

        transform.LookAt(thePlayer.position);

        

    }

    void FixedUpdate()
    {
        //myRb.velocity = (transform.forward * eSpeed);
        //transform.forward = transform.forward * eSpeed;
        transform.Translate(Vector3.forward * eSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update () {

        

        shotCounter -= Time.deltaTime;

        if (shotCounter <= 0.0f)
        {
            shotCounter = timeBetweenshot;
            EGun.isFiring = true;
            EGun1.isFiring = true;
        }
        else {

            EGun.isFiring = false;
            EGun1.isFiring = false;
        }
        


    }
}
