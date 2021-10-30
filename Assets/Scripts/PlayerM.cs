using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
 public float moveSpeed = 125.5f;
 public float jumpHeight = 10.5f;
 private Rigidbody2D body;
 private Animator anim;
 private bool landed;
 private void Awake()
 {
     //grabing referense
     body = GetComponent<Rigidbody2D>();
     anim = GetComponent<Animator>();
 } 
 private void Update()
 {
     float horizontalInput = Input.GetAxis("Horizontal");
     body.velocity = new Vector2(horizontalInput * Time.deltaTime * moveSpeed, body.velocity.y);

     //jumpin
     if(Input.GetKey(KeyCode.Space) && landed)
     {
        Jump(); 
     }
     //flip player horizontally
     if(horizontalInput > 0.01f)
     {
         transform.localScale = Vector3.one;
     }
     else if(horizontalInput < -0.01f)
     {
         transform.localScale = new Vector3(-1,1,1);
     }

     //animation boolean
    anim.SetBool("run",horizontalInput != 0);
    anim.SetBool("landed",landed);
       
 }
 private void Jump()
 {
    body.velocity = new Vector2(body.velocity.x, jumpHeight);
    anim.SetTrigger("jump"); 
    landed = false;
 }
 private void OnCollissionEnter2D(Collission2D col)
 {
     if (col.gameObject.tag == "Ground")
     {
        landed = true;
     }
}
}

