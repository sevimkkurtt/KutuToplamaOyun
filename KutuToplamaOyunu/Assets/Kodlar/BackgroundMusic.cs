using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // �ark�y� ba�lat
    }

    public void StopMusic()
    {
        audioSource.Stop(); // �ark�y� durdur
    }

    public void ChangeMusic(AudioClip newClip)
    {
        audioSource.clip = newClip; // Yeni �ark�y� ayarla
        audioSource.Play(); // Yeni �ark�y� �al
    }
}
