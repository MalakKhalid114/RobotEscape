using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door touched by: " + other.name);
        if (!other.CompareTag("Player")) return;

        if (GameManager.Instance.CanExit())
            GameManager.Instance.WinGame();
        else
            UIManager.Instance.ShowMessage("You need all the Energy Cores to escape!");

    }
}