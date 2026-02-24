using UnityEngine;
using TMPro;


public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public Animator animator;
    public TextMeshProUGUI timerText;
    public GameObject deathScreen;
    private bool timerRunning = true;

    void Update()
    {
        if (!timerRunning) 
        {
            animator.SetFloat("time", 0f);
        return;}

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
        deathScreen.SetActive(true);
        //Time.timeScale = 0f; // Freeze the game

    }

    public void StopTimer()
    {
        timerRunning = false;
    }
}

