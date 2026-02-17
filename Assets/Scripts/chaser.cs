using UnityEngine;

public class EnemyChase2D : MonoBehaviour
{
    [Header("Chase Settings")]
    public float speed = 3f;
    public float detectionRadius = 8f;
    public float stopDistance = 0.5f;

    Transform Player;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player"); // FIXED TAG
        if (p != null) Player = p.transform;
    }

    void FixedUpdate()
    {


        if (Player == null)
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            if (p != null) Player = p.transform;

            rb.linearVelocity = Vector2.zero;
            return;
        }

        float dist = Vector2.Distance(rb.position, Player.position);

        if (dist > detectionRadius || dist <= stopDistance)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }

        Vector2 dir = ((Vector2)Player.position - rb.position).normalized;

        rb.linearVelocity = dir * speed; // FIXED MOVEMENT
    }
}
