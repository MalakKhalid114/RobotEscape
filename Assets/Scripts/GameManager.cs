using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int coresNeeded = 5;
    public float timeLimit = 180f;

    int coresCollected;
    float timeLeft;

    void Awake() => Instance = this;

    void Start()
    {
        timeLeft = timeLimit;
        UIManager.Instance.UpdateCores(0, coresNeeded);
    }

    public void CollectCore()
    {
        coresCollected++;
        UIManager.Instance.UpdateCores(coresCollected, coresNeeded);
    }


    public bool CanExit() => coresCollected >= coresNeeded;

    bool gameOver;

    void Update()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime;
        UIManager.Instance.UpdateTimer(Mathf.Max(timeLeft, 0f));

        if (timeLeft <= 0f)
            LoseGame();
    }

    public void WinGame()
    {
        gameOver = true;
        UIManager.Instance.ShowWin();
    }

    public void LoseGame()
    {
        gameOver = true;
        UIManager.Instance.ShowLose();
    }
}