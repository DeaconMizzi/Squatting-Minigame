using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 15f;
    public float timer;
    public TextMeshProUGUI timerText;
    private bool isTimerRunning = false;
    // Start is called before the first frame update
    void Start()
    {
     timer = totalTime;   
    }

    // Update is called once per frame
    void Update()
    {
       if(isTimerRunning && timer > 0f)
       {
        timer -= Time.deltaTime;
        UpdateTimerText();
        if (timer <= 0f)
        {
            Debug.Log("Game Over!");
        }
       }
    }

    void UpdateTimerText()
    {
        if (timerText != null)
        {
            timerText.text = "Time: "+ Mathf.Round(timer).ToString() +"s";
        }
        else
        {
            Debug.LogError("TextMeshPro is not assigned");
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
    }
}
