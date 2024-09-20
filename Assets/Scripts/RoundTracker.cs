using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoundTracker : MonoBehaviour
{
    [Header("Dynamic")]
    public int round = 1;

    private TextMeshProUGUI uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(round > 4){
            uiText.text = "Game Over";
            
        }else{
            uiText.text = "Round " + round;
        }
        
    }
}
