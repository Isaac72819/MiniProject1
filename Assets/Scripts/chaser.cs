using UnityEngine;

public class chaser : MonoBehaviour
{
    public float speed = 2f;
    public float stoppingDistance = 1.5f;

    private Transform Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        // Force chaser onto 2D plane
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    void Update()
    {
        if (Player == null)
            return;

        float distance = Vector2.Distance(transform.position, Player.position);

        if (distance > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(
                (Vector2)transform.position,
                (Vector2)Player.position,
                speed * Time.deltaTime
            );
        }
    }
}
