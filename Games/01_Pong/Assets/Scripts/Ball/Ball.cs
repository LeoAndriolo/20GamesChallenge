using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 6f;
    public float speedIncrease = 0.5f;
    public AudioClip hitSound;
    public AudioClip wallHitSound;
    private float lastWallHitTime;
    public float wallHitCooldown = 0.03f;

    private Rigidbody2D rb;
    private Collider2D col;
    private AudioSource audioSource;

    private float lastPaddleHitTime;
    private float paddleHitCooldown = 0.05f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;

        col.enabled = true;

        float randomY = Random.Range(-1f, 1f);
        float randomX = Random.value < 0.5f ? -1f : 1f;

        Vector2 direction = new Vector2(randomX, randomY).normalized;
        rb.linearVelocity = direction * startSpeed;
    }

    public void StopBall()
    {
        rb.linearVelocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colidiu com: " + collision.gameObject.name);

        float currentSpeed = rb.linearVelocity.magnitude;
        float normalizedSpeed = Mathf.Clamp01(currentSpeed / 10f);

        if (collision.gameObject.CompareTag("Paddle"))
        {
            if (Time.time - lastPaddleHitTime < paddleHitCooldown) return;
            lastPaddleHitTime = Time.time;

            float hitY = transform.position.y - collision.transform.position.y;
            hitY = Mathf.Clamp(hitY, -0.75f, 0.75f);

            Vector2 direction = new Vector2(
                rb.linearVelocity.x > 0 ? -1f : 1f,
                hitY
            ).normalized;

            if (Mathf.Abs(direction.x) < 0.35f)
            {
                direction.x = Mathf.Sign(direction.x) * 0.35f;
                direction = direction.normalized;
            }

            audioSource.pitch = Mathf.Lerp(0.8f, 1.5f, normalizedSpeed);
            audioSource.PlayOneShot(hitSound);

            float newSpeed = currentSpeed + speedIncrease;
            rb.linearVelocity = direction * newSpeed;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            if (Time.time - lastWallHitTime < wallHitCooldown) return;

            lastWallHitTime = Time.time;
            
            audioSource.pitch = Mathf.Lerp(0.7f, 1.2f, normalizedSpeed);
            audioSource.PlayOneShot(wallHitSound);
        }
    }
}