using UnityEngine;

public class PauseManagerr : MonoBehaviour
{
    private bool isPaused = false; // Oyun duraklat�ld� m�?

    void Update()
    {
        // P tu�una bas�ld���nda oyunu duraklat veya devam ettir
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        if (isPaused)
        {
            // Oyunu devam ettir
            Time.timeScale = 1f; // Zaman� normal h�zda �al��t�r
            isPaused = false; // Duraklama durumu kapal�
        }
        else
        {
            // Oyunu duraklat
            Time.timeScale = 0f; // Zaman� durdur
            isPaused = true; // Duraklama durumu a��k
        }
    }
}

