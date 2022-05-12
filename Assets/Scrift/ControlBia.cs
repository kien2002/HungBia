using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBia : MonoBehaviour
{
    [SerializeField] public AudioSource VoBia;
    // Start is called before the first frame update
    public Image Mang1, Mang2, Mang3;
    public Text gameover;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            //trai
            Debug.Log("A");
            transform.Translate(Vector3.left*12*Time.deltaTime,Space.World);
        }else if(Input.GetKey(KeyCode.D)){
            //phai
            Debug.Log("D");
            transform.Translate(Vector3.right*12*Time.deltaTime,Space.World);
        }
        if(ScoreScrift.mang == 1){
            Destroy(Mang2);
        }else if(ScoreScrift.mang ==2){
            Destroy(Mang2);
            Destroy(Mang3);
        }
        else if(ScoreScrift.mang == 3){
            Destroy(Mang1);
            Destroy(Mang2);
            Destroy(Mang3);
            Destroy(gameObject);
    
            gameover.text = "game over";
        }if(ScoreScrift.scoreValue ==120){
            gameover.text = "Win";
            Destroy(gameObject);
        }else if(ScoreScrift.scoreValue <0){
            gameover.text = "game over";
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D target) {
        Debug.Log("Va cham voi: " + target.gameObject.name);
        if(target.gameObject.tag == "Bia"){
            Destroy(target.gameObject);
            ScoreScrift.scoreValue +=10;
            VoBia.Play();

        }
    }
}
