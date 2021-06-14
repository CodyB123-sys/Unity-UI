using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Animator animator;

    //load the "game"
    public void PlayGame() 
    {
        SceneManager.LoadScene("Level1");
    }

    //quit the game
    public void QuitGame() 
    {
        Application.Quit();
    }
}
