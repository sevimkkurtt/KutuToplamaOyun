using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFinish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // �arp��an nesne "Finish" tag'�na sahipse
        if (other.CompareTag("finish"))
        {
            // "menu" adl� sahneye ge�i� yap
            SceneManager.LoadScene("Menu");
        }
    }
}
