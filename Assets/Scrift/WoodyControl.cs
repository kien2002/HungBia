using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodyControl : MonoBehaviour
{
    // Start is called before the first frame update
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
            Debug.Log("chay");
            animator.SetInteger("Status",1);
            renderer.flipX = false;
            transform.Translate(Vector3.left*5*Time.deltaTime,Space.World);
            fireBallController.isRight = true;
        }else if(Input.GetKey(KeyCode.D)){
            //phai
            Debug.Log("chay");
            animator.SetInteger("Status",1);
            renderer.flipX = true;
            transform.Translate(Vector3.right*5*Time.deltaTime,Space.World);
            fireBallController.isRight = false;
        }
        else if(Input.GetKey(KeyCode.W)){
            //phai
            Debug.Log("chay");
            animator.SetInteger("Status",1);
            transform.Translate(Vector3.up*5*Time.deltaTime,Space.World);
        }
        else if(Input.GetKey(KeyCode.S)){
            //phai
            Debug.Log("chay");
            animator.SetInteger("Status",1);
            transform.Translate(Vector3.down*5*Time.deltaTime,Space.World);
        }
        else if(Input.GetKeyDown(KeyCode.J)){
            //dam
            Debug.Log("dam");
            animator.SetInteger("Status",2);
        }else if(Input.GetKeyDown(KeyCode.K)){
            //da
            Debug.Log("da");
            animator.SetInteger("Status",3);
        }else if(Input.GetKeyDown(KeyCode.L)){
            //skill
            Debug.Log("skill");
            animator.SetInteger("Status",4);
        }else if(Input.GetKeyDown(KeyCode.O)){
            Debug.Log("dung yen");
            animator.SetInteger("Status",0);
        }else if(Input.GetKeyDown(KeyCode.H)){
            Debug.Log("chuong");
            animator.SetInteger("Status",4);
            Instantiate(chuong,gameObject.transform.position,Quaternion.identity);
        }else if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Nhay");
            animator.SetInteger("Status",0);
            rigidbody2D.AddForce(transform.up*5f,ForceMode2D.Impulse);
        }
    }
}
