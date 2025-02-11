using UnityEngine;
using UnityEngine.SceneManagement; // Sahne de�i�tirme i�lemleri i�in gerekli

public class EscToMenu: MonoBehaviour
{
    void Update()
    {
        // ESC tu�una bas�ld���nda �al��t�r
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Menu sahnesine ge�i� yap
            LoadMenuScene();
        }
    }

    private void LoadMenuScene()
    {
        // Sahne ad�n� kullanarak veya build index'e g�re sahne y�kle
        SceneManager.LoadScene("Menu"); // Men� sahnesinin ad�
        // E�er sahne ad� yerine build index kullanmak isterseniz:
        // SceneManager.LoadScene(1);
    }
}
