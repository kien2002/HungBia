using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour
{
    public int speed = 5;
    public bool isRight = true;
    public GameObject No;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isRight){
            spriteRenderer.flipX = true;
            transform.Translate(Vector3.left*speed*Time.deltaTime,Space.World);
        }else{
            spriteRenderer.flipX = false;
            transform.Translate(Vector3.right*speed*Time.deltaTime,Space.World);
        }
    }
     void OnCollisionEnter2D(Collision2D col)
        {
            Debug.Log("Va cham voi: " + col.gameObject.name);
            if(col.gameObject.tag == "Frog")
            {
                GameObject e = Instantiate(No) as GameObject;
                e.transform.position = transform.position;
                col.gameObject.SetActive(false);
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }
}
