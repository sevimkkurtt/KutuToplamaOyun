using UnityEngine;
using UnityEngine.UI; // Legacy Text i�in gerekli

public class KalanKupSayaci : MonoBehaviour
{
    public Text kupSayisiText; // Legacy Text referans�
    private int kupSayisi = 1; // Oyun ba��nda 1 k�p ile ba�l�yor

    void Start()
    {

        GuncelleKupSayisi(); // Oyunun ba��nda k�p say�s�n� g�ster
    }

    public void KupEkle() // Topla tag'ine ait nesneleri toplad���nda �a��r
    {
        kupSayisi++; // K�p say�s�n� art�r
        GuncelleKupSayisi(); // Ekran� g�ncelle
    }

    public void KupEksilt() // EngelK�p'e �arpt���nda �a��r
    {
        if (kupSayisi > 0)
        {
            kupSayisi--; // K�p say�s�n� azalt
            GuncelleKupSayisi(); // Ekran� g�ncelle
        }
    }

    private void GuncelleKupSayisi()
    {
        kupSayisiText.text = "K�p Say�s�: " + kupSayisi; // Text bile�enini g�ncelle
    }
  


    void OnCollisionEnter(Collision collision)
    {
        // EngelK�p'e �arpt���nda k�p say�s�n� azalt
        if (collision.gameObject.CompareTag("Engel"))
        {
            KupEksilt();
        }

        // Topla tag'ine ait nesnelere �arpt���nda k�p say�s�n� art�r ve nesneyi yok et
        if (collision.gameObject.CompareTag("Topla"))
        {
            KupEkle();
            Destroy(collision.gameObject); // Toplanan nesneyi sahneden kald�r
        }
    }
}
