using UnityEngine;

public class GoalZoneTrigger : MonoBehaviour
{
    public bool givesPointToLeftPlayer;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Ball")) return;

        if (givesPointToLeftPlayer)
        {
            gameManager.AddPointToLeftPlayer();
        }
        else
        {
            gameManager.AddPointToRightPlayer();
        }
    }
}