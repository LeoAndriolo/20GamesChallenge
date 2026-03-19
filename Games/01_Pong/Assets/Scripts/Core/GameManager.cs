using UnityEngine;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    public int goalsToWin = 3;

    public AudioSource audioSource;

    public AudioClip goalSound;
    public float goalVolume = 0.7f;
    public AudioClip winSound;
    public float winVolume = 1f;
    public AudioClip loseSound;
    public float loseVolume = 1f;
    
    public TextMeshProUGUI leftScoreText;
    public TextMeshProUGUI rightScoreText;
    public TextMeshProUGUI resultText;
    public GameObject menuPanel;
    public GameObject resultPanel;

    public Ball ball;
    public GameState currentState;

    private void Start()
    {
        UpdateScoreUI();
        resultPanel.SetActive(false);
        SetState(GameState.Menu);
    }

    public void StartGame()
    {
        leftScore = 0;
        rightScore = 0;
        UpdateScoreUI();
        resultPanel.SetActive(false);

        SetState(GameState.Playing);
        ball.ResetBall();
    }

    public void ResetGame()
    {
        leftScore = 0;
        rightScore = 0;
        UpdateScoreUI();
        resultPanel.SetActive(false);

        if (currentState == GameState.Playing)
            ball.ResetBall();
    }

    public void AddPointToLeftPlayer()
    {
        if (currentState != GameState.Playing) return;

        leftScore++;
        UpdateScoreUI();

        audioSource.PlayOneShot(goalSound, goalVolume);

        if (leftScore >= goalsToWin)
        {
            StartCoroutine(EndGameRoutine("You Lose!"));
            return;
        }

        ball.ResetBall();
    }

    public void AddPointToRightPlayer()
    {
        if (currentState != GameState.Playing) return;

        rightScore++;
        UpdateScoreUI();

        audioSource.PlayOneShot(goalSound, goalVolume);

        if (rightScore >= goalsToWin)
        {
            StartCoroutine(EndGameRoutine("You Win!"));
            return;
        }

        ball.ResetBall();
    }

    private void UpdateScoreUI()
    {
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }

    private IEnumerator EndGameRoutine(string message)
    {
        SetState(GameState.GameOver);
        ball.StopBall();

        resultText.text = message;
        resultPanel.SetActive(true);

        if (message == "You Win!")
        {
            audioSource.Stop();
            audioSource.PlayOneShot(winSound, winVolume);
        }
        else
        {
            audioSource.Stop();
            audioSource.PlayOneShot(loseSound, loseVolume);
        }

        yield return new WaitForSecondsRealtime(2f);

        ReturnToMenu();
    }

    public void ReturnToMenu()
    {
        leftScore = 0;
        rightScore = 0;
        UpdateScoreUI();

        resultPanel.SetActive(false);
        ball.StopBall();
        ball.transform.position = Vector3.zero;

        SetState(GameState.Menu);
    }

    private void SetState(GameState newState)
    {
        currentState = newState;

        switch (newState)
        {
            case GameState.Menu:
                Time.timeScale = 0f;
                menuPanel.SetActive(true);
                break;

            case GameState.Playing:
            case GameState.GameOver:
                Time.timeScale = 1f;
                menuPanel.SetActive(false);
                break;
        }
    }
}