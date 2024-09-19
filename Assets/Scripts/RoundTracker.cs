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
        uiText.text = "Round " + round;
    }
}
