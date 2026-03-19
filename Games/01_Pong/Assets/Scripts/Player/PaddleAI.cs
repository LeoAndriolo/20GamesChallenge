using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 6f;
    
    public float reactionTime = 0.2f;
    public float errorMargin = 0.5f;
    
    public float minY = -3;
    public float maxY = 3;

    private float targetY;
    private float timer;

    public Difficulty difficulty;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= reactionTime)
        {
            timer = 0f;

            float error = Random.Range(-errorMargin, errorMargin);
            targetY = ball.position.y + error;
        }

        Vector3 pos = transform.position;

        pos.y = Mathf.MoveTowards(pos.y, targetY, moveSpeed * Time.deltaTime);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}