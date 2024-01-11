using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Text scoreText;
    public float lumberscore=0f;
    public float treescore;
    public countDownTimer countDownTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (countDownTimer.timeLeft > 0)
        {
            scoreText.text = (lumberscore + treescore).ToString("0");
        }
        
    }
}
