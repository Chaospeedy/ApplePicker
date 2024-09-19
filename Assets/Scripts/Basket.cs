using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public RoundTracker roundTracker;

    private int applesCaught = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        GameObject roundGO = GameObject.Find("RoundTracker");

        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
        roundTracker = roundGO.GetComponent<RoundTracker>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll){
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Apple")){
            Destroy(collidedWith);

            applesCaught++;
            if(applesCaught %15 == 0){ //each round is 15 apples
                applesCaught = 0;
                
                if(roundTracker.round++ > 4){ //game ends after 4 rounds are completed

                }
            }
            
            scoreCounter.score += 100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }
    }
}
