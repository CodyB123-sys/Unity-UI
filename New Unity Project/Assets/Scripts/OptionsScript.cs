using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void OptionsMenuEnter() 
    {
        animator.Play("OptionsMenuEnter");
    }

    public void OptionsMenuExit()
    { 
    
    }
}
