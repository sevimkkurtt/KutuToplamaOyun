using UnityEngine;

public class PauseManagerr : MonoBehaviour
{
    private bool isPaused = false; // Oyun duraklatýldý mý?

    void Update()
    {
        // P tuþuna basýldýðýnda oyunu duraklat veya devam ettir
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
            Time.timeScale = 1f; // Zamaný normal hýzda çalýþtýr
            isPaused = false; // Duraklama durumu kapalý
        }
        else
        {
            // Oyunu duraklat
            Time.timeScale = 0f; // Zamaný durdur
            isPaused = true; // Duraklama durumu açýk
        }
    }
}

