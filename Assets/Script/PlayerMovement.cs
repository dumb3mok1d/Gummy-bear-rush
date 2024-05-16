using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private UIManager uiManager;

    private void Awake()
    {
        // grab references for rigidbody and animator 
        body= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(8, 7, 1);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-8,7, 1);

        if (Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);

        //Set animator parameters
        anim.SetBool("walking", horizontalInput != 0);

      
    }
}  
