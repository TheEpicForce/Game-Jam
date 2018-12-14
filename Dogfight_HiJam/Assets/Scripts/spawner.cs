using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject enemy;
    public Transform[] points;

    

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (timeBtwSpawn <= 0)
        {
            int index = Random.Range(0, 6);

            Instantiate(enemy, points[index].position, Quaternion.identity);

            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }

        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }

      

    }
}
