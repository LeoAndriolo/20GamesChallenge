using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startSpeed = 6f;
    public float speedIncrease = 0.5f;
    public AudioClip hitSound;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector2.zero;

        GetComponent<Collider2D>().enabled = true;

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
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float hitY = transform.position.y - collision.transform.position.y;
            Vector2 direction = new Vector2(
                rb.linearVelocity.x > 0 ? -1f : 1f,
                hitY
            ).normalized;

            float currentSpeed = rb.linearVelocity.magnitude;

            // Ajuste de pitch baseado na velocidade
            float normalizedSpeed = Mathf.Clamp01(currentSpeed / 10f);
            audioSource.pitch = Mathf.Lerp(0.8f, 1.5f, normalizedSpeed);

            audioSource.PlayOneShot(hitSound);

            float newSpeed = rb.linearVelocity.magnitude + speedIncrease;
            rb.linearVelocity = direction * newSpeed;
        }
    }
}