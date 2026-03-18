using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Transform ball;
    public float moveSpeed = 6f;
    public float minY = -3.25f;
    public float maxY = 3.25f;

    private void Update()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.MoveTowards(pos.y, ball.position.y, moveSpeed * Time.deltaTime);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}