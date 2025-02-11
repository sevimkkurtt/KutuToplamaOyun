using UnityEngine;

public class ParticleOnCollision : MonoBehaviour
{
    public GameObject particleEffectPrefab;  // Partikül prefab'ýný buraya atayýn
    private GameObject particleInstance;    // Partikül instantiating için deðiþken

    void Start()
    {
        // Partikül sistemini Player'ýn child'ý olarak baþlatýyoruz
        particleInstance = Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
        particleInstance.SetActive(false);  // Baþlangýçta partikülü gizle
        particleInstance.transform.SetParent(transform); // Player'ýn child'ý yap
    }

    void OnCollisionEnter(Collision collision)
    {
        // Çarpýþma "Engel" tag'ýna sahip bir nesneyle olursa
        if (collision.gameObject.CompareTag("Engel"))
        {
            // Partikül sistemini aktif et
            particleInstance.SetActive(true);
            // Çarpýþma noktasýna partikül efekti yerleþtir
            particleInstance.transform.position = collision.contacts[0].point;
        }
    }
}
