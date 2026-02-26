using UnityEngine;
using TMPro;


public class GameTimer : MonoBehaviour
{
    public float timeRemaining;
    public TextMeshProUGUI timerText;
    private bool timerRunning = true;


    void Update()
    {
        if (!timerRunning) 
        {return;}

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            timeRemaining = 0;
            timerRunning = false;
            TimerEnded();
        }
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    void TimerEnded()
    {
        
    }

    public void StopTimer()
    {
        timerRunning = false;
    }
}

