using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dat : MonoBehaviour
{
    public Text hetgame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D target) {
        Debug.Log("Va cham voi: " + target.gameObject.name);
        if(target.gameObject.tag == "Bia"){
            Destroy(target.gameObject);
            ScoreScrift.mang +=1;
            if(ScoreScrift.scoreValue >10){
                ScoreScrift.scoreValue +=-10;
            if(ScoreScrift.mang ==2){
                ScoreScrift.scoreValue +=-10;
            }else if(ScoreScrift.mang ==3){
                ScoreScrift.scoreValue +=-20;
            }
        }
}
}
}   
