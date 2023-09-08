using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gamemanager;
    
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gamemanager.WinGame();
        }
    }
}
