using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Loads next scene in the build
    }

    public void ExitGame()
    {
        Application.Quit(); //Quits the game
        Debug.Log("Game has quit"); //Writes in the console for testing purposes
    }

}
