using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour {

    public float enemyBulletspeed;

    public float lifeTime;

    public int damageToGive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * enemyBulletspeed * Time.deltaTime);

        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerHealth>().HurtPlayer(damageToGive);

            Debug.Log("Here");

            Destroy(gameObject);
        }
    }



}
