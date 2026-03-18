using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 6f;
    public float speedIncrease = 0.5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector2.zero;

        float randomY = Random.Range(-1f, 1f);
        float randomX = Random.value < 0.5f ? -1f : 1f;

        Vector2 direction = new Vector2(randomX, randomY).normalized;
        rb.linearVelocity = direction * startSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float hitY = transform.position.y - collision.transform.position.y;
            Vector2 direction = new Vector2(
                rb.linearVelocity.x > 0 ? -1f : 1f,
                hitY
            ).normalized;

            float newSpeed = rb.linearVelocity.magnitude + speedIncrease;
            rb.linearVelocity = direction * newSpeed;
        }
    }
}