using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiaS : MonoBehaviour
{
    [SerializeField] private AudioSource rotBia;
    public Sprite Anh2,Anh3,Anh4;

    void Update()
    {
        if(ScoreScrift.scoreValue == 50){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh2;
            rotBia.Play();
        }
        if(ScoreScrift.scoreValue == 100){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh3;
            rotBia.Play();
        }
        if(ScoreScrift.scoreValue == 150){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh4;
            rotBia.Play();
        }
    }
}
