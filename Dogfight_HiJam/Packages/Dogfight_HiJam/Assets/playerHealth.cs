using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

    public int health;

    public int currentHealth;

    public Slider slide;

    public GameObject pSys;
    bool isDead;

    // Use this for initialization
    void Start()
    {
        //ep = gameObject.GetComponent<explode_plane>();
        pSys.SetActive(false);
        isDead = false;

        currentHealth = health;
    }
    private IEnumerator death()
    {
        // play death animation explosion
        //ep.Explode();
        

        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        slide.value = currentHealth;

        if (currentHealth <= 0)
        {
            // gameObject.SetActive(false);
            isDead = true;
        }
        
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    currentHealth--;
        //}

        if (isDead)
        {
            pSys.SetActive(true);
            StartCoroutine(death());
        }
    }

    public void HurtPlayer(int damage)
    {

        currentHealth -= damage;

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.name == "Terrain" || other.name == "He_51(Clone)")
        {
            Debug.Log("Trigger Entered" + other.name);
            currentHealth -= 30;
        }
    }
}
