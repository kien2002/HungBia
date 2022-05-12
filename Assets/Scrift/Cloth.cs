using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : MonoBehaviour
{
    public Sprite Anh2,Anh3,Anh4,Anh5;
    void Update()
    {
        if(ScoreScrift.scoreValue == 40){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh2;
        }
        if(ScoreScrift.scoreValue == 80){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh3;
        }
        if(ScoreScrift.scoreValue == 100){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh4;
        }
        if(ScoreScrift.scoreValue == 120){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Anh5;
        }
    }
}
