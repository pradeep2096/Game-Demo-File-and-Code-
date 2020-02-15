using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody2D rb;
    SpriteRenderer sr;
    public bool grounded;
    public float gravity;
    public float Speed;
    public int jumpheight;
    Animator animator;
    public bool Movement;
    AudioSource audirunning;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Time.timeScale = 1f;
        audirunning = GetComponent<AudioSource>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            grounded = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //scenemanager();
        float horizontal = Input.GetAxis("Horizontal");
        PlayerMovement(horizontal);

         if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sr.flipX = true;
            //audirunning.volume = 1f;
        } 

         else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            sr.flipX = false;
            //audirunning.volume = 1f;
        }
            


        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, calculateJump());
            animator.SetBool("JackJump", true);
            audirunning.volume = 0f;

        }
        else
        {
            animator.SetBool("JackJump", false);
        }

        rb.AddForce(new Vector2(0, -gravity * rb.mass));
        
    }
    private void PlayerMovement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * Speed, rb.velocity.y);
        animator.SetFloat("Rspeed",Mathf.Abs(horizontal));
        audirunning.volume=Mathf.Abs(horizontal);
        Movement = true;

    }
    float calculateJump()
    {
        float Jump = Mathf.Sqrt(2 * jumpheight * gravity);
        return Jump;

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Black") || (collision.gameObject.tag == "White"))
        {
            //Destroy(this.gameObject);
            if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene1)
            {
                gamemanagerr.health -= 15;
            }
            if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene2)
            {
                gamemanagerr.health -= 20;
            }
            if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene3)
            {
                gamemanagerr.health -= 25;
            }
           
        }
    }
    

}
