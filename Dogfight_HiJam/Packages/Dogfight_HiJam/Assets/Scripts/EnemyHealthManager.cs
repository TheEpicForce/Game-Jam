using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHealthManager : MonoBehaviour {


    
    public int health;

    private int currentHealth;

    public int scoreValue = 1;

    public float lifeTime;

    // Use this for initialization
    void Start () {

        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {

        //lifeTime -= Time.deltaTime;

        //if (lifeTime <= 0)
       // {
       //     Destroy(gameObject);
       // }

        if (currentHealth <= 0)
        {
           ScoreManager.score += scoreValue;
           Destroy(gameObject);
            
        }
        
    }

    public void HurtEnemy(int damage) {

        currentHealth -= damage;

    }
}
