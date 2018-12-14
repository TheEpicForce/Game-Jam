using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    private PlayerController player;

    public GameObject DeathParticle;

    public int pointPenaltyOnDeath;

    public float respawnDelay; 
    
    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void RespawnPlayer() 
   
    {
        StartCoroutine("RespawnPlayerCo"); 
    }

    public IEnumerator RespawnPlayerCo() 
    {
        Instantiate(DeathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.RGB2D.gravityScale = 0f; 
        ScoreManager.AddPoints(-pointPenaltyOnDeath);
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
    }
}

