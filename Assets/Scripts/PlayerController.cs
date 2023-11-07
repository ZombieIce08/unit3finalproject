using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public bool isDead;
    private Animator animator;
    



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        animator = rb.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("OBSTACLE!");     
            isDead = true;
            animator.SetTrigger("Die");
        }
    }
}
