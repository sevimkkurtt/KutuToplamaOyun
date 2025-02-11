using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Þarkýyý baþlat
    }

    public void StopMusic()
    {
        audioSource.Stop(); // Þarkýyý durdur
    }

    public void ChangeMusic(AudioClip newClip)
    {
        audioSource.clip = newClip; // Yeni þarkýyý ayarla
        audioSource.Play(); // Yeni þarkýyý çal
    }
}
