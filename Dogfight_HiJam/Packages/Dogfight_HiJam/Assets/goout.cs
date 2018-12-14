using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goout : MonoBehaviour {


    //public GameObject thePlayer;
    //public GameObject theEnemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) {

            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (other.CompareTag("Enemy"))
        {

            Destroy(gameObject);
        }
    }
}
