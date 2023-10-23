using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlayerController : MonoBehaviour
{
   
    //Jumping Variables
    private Rigidbody rb;
    public float jumpForce;

    //Animattion Variables
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        //Get Components
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
