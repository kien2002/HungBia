using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Animator animator;
    SpriteRenderer renderer;
    public GameObject chuong;
    FireBallController fireBallController;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
        fireBallController = chuong.GetComponent<FireBallController>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            //trai
            animator.SetInteger("Status",1);
            renderer.flipX = false;
            transform.Translate(Vector3.left*5*Time.deltaTime,Space.World);
            fireBallController.isRight = true;
        }else if(Input.GetKey(KeyCode.D)){
            //phai
            animator.SetInteger("Status",1);
            renderer.flipX = true;
            transform.Translate(Vector3.right*5*Time.deltaTime,Space.World);
            fireBallController.isRight = false;
        }
        else if(Input.GetKey(KeyCode.W)){
            //phai
            animator.SetInteger("Status",1);
            transform.Translate(Vector3.up*5*Time.deltaTime,Space.World);
        }else if(Input.GetKeyDown(KeyCode.H)){
            animator.SetInteger("Status",0);
            Instantiate(chuong,gameObject.transform.position,Quaternion.identity);
        }else if(Input.GetKey(KeyCode.Space)){
            animator.SetInteger("Status",0);
            rigidbody2D.AddForce(transform.up*10f,ForceMode2D.Impulse);
        }
    }
}
