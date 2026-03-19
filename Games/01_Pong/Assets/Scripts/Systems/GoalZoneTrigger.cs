using UnityEngine;

public class GoalZoneTrigger : MonoBehaviour
{
    public bool givesPointToLeftPlayer;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Ball")) return;

        if (gameManager.currentState != GameState.Playing) return;

        // Adicionar SFX

        // Evita múltiplos triggers
        other.enabled = false;

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