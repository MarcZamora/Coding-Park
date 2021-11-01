using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
[SerializeField] private LayerMask groundLayer;
 public float moveSpeed = 125.5f;
 public float jumpHeight = 10.5f;
 private Rigidbody2D body;
 private Animator anim;
 private BoxCollider2D boxcol;
 

 private void Awake()
 {
     //grabing referense
     body = GetComponent<Rigidbody2D>();
     anim = GetComponent<Animator>();
     boxcol = GetComponent<BoxCollider2D>();

 } 
 private void Update()
 {
     float horizontalInput = Input.GetAxis("Horizontal");
     body.velocity = new Vector2(horizontalInput * Time.deltaTime * moveSpeed, body.velocity.y);

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
    anim.SetBool("landed",isLanded());

    //jumpin
     if(Input.GetKey(KeyCode.Space) && isLanded())
     {
        Jump(); 
     }
       
    //destroy
    if (transform.localPosition.y <= -10)
    {
        Destroy(gameObject);
    }
 }
 private void Jump()
 {
    body.velocity = new Vector2(body.velocity.x, jumpHeight);
    anim.SetTrigger("jump"); 
 }
 private void OnCollisionEnter2D(Collision2D col)
 {
  
 }
 private bool isLanded()
 {
     RaycastHit2D rH2D = Physics2D.BoxCast(boxcol.bounds.center, boxcol.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
     return rH2D.collider != null;
 }
 
 
}

