using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {


    public bool isFiring;

    public BulletController bullet;

    public float bulletSpeed;

    public float timeBetweenshots;
    private float shotCounter;

    public Transform firePoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isFiring)
        {
            

            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenshots;

                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;

            }
            else {

                shotCounter -= Time.deltaTime;
            }
        }
	}
}
