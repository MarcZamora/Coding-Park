using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerM : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float moveSpeed;
    public float jumpHeight;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxcol;

    // public GameObject[] player;
    
    
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
            transform.localScale = new Vector3(5,5,5);
        }
        else if(horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-5,5,5);
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
    
    private bool isLanded()
    {
        RaycastHit2D rH2D = Physics2D.BoxCast(boxcol.bounds.center, boxcol.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return rH2D.collider != null;
    }

    // void Start()
    // {
    //     DontDestroyOnLoad(gameObject);
    // }
    // private void OnLevelWasLoaded(int level)
    // {
    //     FindStartPos();
    //     player.GameObject.FindGameObjectWithTag("Player");
    //     if(player.Lenght > 1)
    //     {
    //         Destroy(player[1]);
    //     }    
    // }

}

