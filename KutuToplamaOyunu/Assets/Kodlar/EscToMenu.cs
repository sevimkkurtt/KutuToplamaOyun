using UnityEngine;
using UnityEngine.SceneManagement; // Sahne deðiþtirme iþlemleri için gerekli

public class EscToMenu: MonoBehaviour
{
    void Update()
    {
        // ESC tuþuna basýldýðýnda çalýþtýr
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Menu sahnesine geçiþ yap
            LoadMenuScene();
        }
    }

    private void LoadMenuScene()
    {
        // Sahne adýný kullanarak veya build index'e göre sahne yükle
        SceneManager.LoadScene("Menu"); // Menü sahnesinin adý
        // Eðer sahne adý yerine build index kullanmak isterseniz:
        // SceneManager.LoadScene(1);
    }
}
