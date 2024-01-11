using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{
    public float totalTime = 5.0f;
    public float timeLeft;

    public TextMeshProUGUI countDownTime;

    void Start()
    {
        timeLeft = totalTime;
        StartCoroutine("Countdown");
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            countDownTime.text = timeLeft.ToString("0.0");
            yield return new WaitForSeconds(0.1f);
            timeLeft -= 0.1f;
        }
        countDownTime.text = "0";
        Time.timeScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
