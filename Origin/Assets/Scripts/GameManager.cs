using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float RestartOffset = 1f;
    public GameObject CompleteLevelUI;
    public GameObject DeathGameUI;
    public void EndGame()
    {
        DeathGameUI.SetActive(true);
    }

    public void WinGame()
    {
        Debug.Log("WON!!!!");
        CompleteLevelUI.SetActive(true);
    }
}

