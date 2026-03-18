using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;

    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;

    public Ball ball;

    private void Start()
    {
        UpdateScoreUI();
        ball.ResetBall();
    }

    public void AddPointToLeftPlayer()
    {
        leftScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    public void AddPointToRightPlayer()
    {
        rightScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    void UpdateScoreUI()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }
}