using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    //load the "game"
    public void PlayGame() 
    {
        animator.Play("MainMenuExit");
        Invoke("StartGame", 0.3f);
    }

    //quit the game
    public void QuitGame() 
    {
        Application.Quit();
    }

    void StartGame() 
    {
        SceneManager.LoadScene("Level1");
    }
}
