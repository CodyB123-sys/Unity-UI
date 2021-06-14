﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Animator animator;
    public GameObject options;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    //load the "game"
    public void PlayGame() 
    {
        MainMenuExit();
        Invoke("StartGame", 0.3f);
    }

    //quit the game
    public void QuitGame() 
    {
        MainMenuExit();
        Invoke("CloseGame", 0.3f);
    }

    public void OptionsClick()
    {
        MainMenuExit();
        Invoke("SetOptionsActive", 0.3f);
    }

    public void SetOptionsActive()
    {
        options.SetActive(true);
    }

    void CloseGame()
    {
        Application.Quit();
    }

    void StartGame() 
    {
        SceneManager.LoadScene("Level1");
    }

    void MainMenuExit()
    {
        animator.Play("MainMenuExit");
    }
}
