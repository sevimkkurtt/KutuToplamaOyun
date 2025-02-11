using UnityEngine;
using UnityEngine.UI; // Legacy Text için gerekli

public class KalanKupSayaci : MonoBehaviour
{
    public Text kupSayisiText; // Legacy Text referansý
    private int kupSayisi = 1; // Oyun baþýnda 1 küp ile baþlýyor

    void Start()
    {

        GuncelleKupSayisi(); // Oyunun baþýnda küp sayýsýný göster
    }

    public void KupEkle() // Topla tag'ine ait nesneleri topladýðýnda çaðýr
    {
        kupSayisi++; // Küp sayýsýný artýr
        GuncelleKupSayisi(); // Ekraný güncelle
    }

    public void KupEksilt() // EngelKüp'e çarptýðýnda çaðýr
    {
        if (kupSayisi > 0)
        {
            kupSayisi--; // Küp sayýsýný azalt
            GuncelleKupSayisi(); // Ekraný güncelle
        }
    }

    private void GuncelleKupSayisi()
    {
        kupSayisiText.text = "Küp Sayýsý: " + kupSayisi; // Text bileþenini güncelle
    }
  


    void OnCollisionEnter(Collision collision)
    {
        // EngelKüp'e çarptýðýnda küp sayýsýný azalt
        if (collision.gameObject.CompareTag("Engel"))
        {
            KupEksilt();
        }

        // Topla tag'ine ait nesnelere çarptýðýnda küp sayýsýný artýr ve nesneyi yok et
        if (collision.gameObject.CompareTag("Topla"))
        {
            KupEkle();
            Destroy(collision.gameObject); // Toplanan nesneyi sahneden kaldýr
        }
    }
}
