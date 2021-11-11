using System.Collections.Generic;
using UnityEngine;


public class PlayerM : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float moveSpeed, jumpHeight;
    private Rigidbody2D rb2d;
    private Animator anim;
    private PolygonCollider2D polycol;
    private bool moveLeft, moveRight;

    // public GameObject[] player;
    
    
    private void Awake()
    {
        //grabing referense
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        polycol = GetComponent<PolygonCollider2D>();

    } 

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(horizontalInput * Time.deltaTime * moveSpeed, rb2d.velocity.y);

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

        
        
        //destroy
        if (transform.localPosition.y <= -10)
        {
            Destroy(gameObject);
        }

    //controls
        if (moveRight)
        {
          rb2d.velocity = new Vector2(1f * Time.deltaTime * moveSpeed, rb2d.velocity.y);
          transform.localScale = new Vector3(5,5,5);
          anim.SetBool("run",1f != 0);
        }
         if (moveLeft)
        {
          rb2d.velocity = new Vector2(-1f * Time.deltaTime * moveSpeed, rb2d.velocity.y);
          transform.localScale = new Vector3(-5,5,5);
          anim.SetBool("run",-1f != 0);
        }
    //controls//

        //jumpin
        if(Input.GetKey(KeyCode.Space) && isLanded())
        {
            Jump(); 
        }
        
    }

    public void Jump()
    {
        if (rb2d.velocity.y == 0)
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
        anim.SetTrigger("jump"); 
        }
    }
    
    private bool isLanded()
    {
        RaycastHit2D rH2D = Physics2D.BoxCast(polycol.bounds.center, polycol.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return rH2D.collider != null;
    }

    //movecontrol
    public void Start()
    {
      moveLeft = false;
        moveRight = false;
    }

    public void MoveLeft()
    {
        moveLeft = true;        
    }

    public void MoveRight()
    {
        moveRight = true;
    }


    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb2d.velocity = Vector2.zero;
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

