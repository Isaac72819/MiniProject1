using UnityEngine;

public class death : MonoBehaviour
{
public Rigidbody2D body;
public GameTimer timer;
public Animator animator;
public GameObject deathScreen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        timer = FindAnyObjectByType<GameTimer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timeRemaining <= 0)
        {
        body.linearVelocity = new Vector2(0f, 0f);
        transform.localScale = new Vector3(4f, 4f, 4f);
        animator.SetFloat("time", 0f);      
        deathScreen.SetActive(true);      
        timer.StopTimer(); // Stop the timer
        }
    }
}
