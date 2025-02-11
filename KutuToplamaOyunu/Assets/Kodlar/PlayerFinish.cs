using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFinish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Çarpýþan nesne "Finish" tag'ýna sahipse
        if (other.CompareTag("finish"))
        {
            // "menu" adlý sahneye geçiþ yap
            SceneManager.LoadScene("Menu");
        }
    }
}
