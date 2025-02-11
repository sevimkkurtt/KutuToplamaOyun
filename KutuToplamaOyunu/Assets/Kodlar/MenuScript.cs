using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {
      

        // Oyunu en baþtan baþlat
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        // Unity Editor'da çalýþýrken oyunu "sonlandýrmak" için
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Build edilmiþ oyunda çalýþýrken tamamen çýkmak için
        Application.Quit();
#endif
    }

    public void LevelButton()
    {
        SceneManager.LoadScene(2);
    }
}
