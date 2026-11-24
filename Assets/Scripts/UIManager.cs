using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TMP_Text timerText, coresText;

    void Awake() => Instance = this;

    public void UpdateCores(int c, int n) =>
        coresText.text = $"Energy Cores: {c} / {n}";

    public void UpdateTimer(float t) =>
        timerText.text = $"Time: {Mathf.FloorToInt(t / 60):00}:{Mathf.FloorToInt(t % 60):00}";

    public TMP_Text messageText;

    public void ShowMessage(string msg)
    {
        messageText.text = msg;
        CancelInvoke();
        Invoke(nameof(ClearMessage), 2f);
    }

    void ClearMessage() => messageText.text = "";
    public GameObject winPanel, losePanel;

    public void ShowWin()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ShowLose()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
