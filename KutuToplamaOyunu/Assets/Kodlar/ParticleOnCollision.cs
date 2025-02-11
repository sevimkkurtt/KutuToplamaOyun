using UnityEngine;

public class ParticleOnCollision : MonoBehaviour
{
    public GameObject particleEffectPrefab;  // Partik�l prefab'�n� buraya atay�n
    private GameObject particleInstance;    // Partik�l instantiating i�in de�i�ken

    void Start()
    {
        // Partik�l sistemini Player'�n child'� olarak ba�lat�yoruz
        particleInstance = Instantiate(particleEffectPrefab, transform.position, Quaternion.identity);
        particleInstance.SetActive(false);  // Ba�lang��ta partik�l� gizle
        particleInstance.transform.SetParent(transform); // Player'�n child'� yap
    }

    void OnCollisionEnter(Collision collision)
    {
        // �arp��ma "Engel" tag'�na sahip bir nesneyle olursa
        if (collision.gameObject.CompareTag("Engel"))
        {
            // Partik�l sistemini aktif et
            particleInstance.SetActive(true);
            // �arp��ma noktas�na partik�l efekti yerle�tir
            particleInstance.transform.position = collision.contacts[0].point;
        }
    }
}
