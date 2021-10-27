using UnityEngine;

public class PlayerM : MonoBehaviour
{
 public float moveSpeed = 125.5f;
 public float jumpHeight = 10.5f;
 private Rigidbody2D body;
 private void Awake()
 {
     body = GetComponent<Rigidbody2D>();
 } 
 private void Update()
 {
     float horizontalInput = Input.GetAxis("Horizontal");
     body.velocity = new Vector2(horizontalInput * Time.deltaTime * moveSpeed, body.velocity.y);
     //jumpin
     if(Input.GetKey(KeyCode.Space))
     {
         body.velocity = new Vector2(body.velocity.x, jumpHeight);
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
     
 }
}
