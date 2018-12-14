using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

    public int health;

    public int currentHealth;

    public Slider slide;

    // Use this for initialization
    void Start()
    {

        currentHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        slide.value = currentHealth;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void HurtPlayer(int damage)
    {

        currentHealth -= damage;

    }

}
