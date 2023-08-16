using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("QUIT!");
    }
}
