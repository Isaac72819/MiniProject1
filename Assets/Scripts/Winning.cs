using UnityEngine;

public class WinZone : MonoBehaviour
{
 
    public GameObject winScreen; // Assign in Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f; // optional: freeze game
        }
    }
}