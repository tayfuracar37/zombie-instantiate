using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dusmanPrefab; // Oluþturulacak düþman prefab'ý
    public int dusmanSayisi = 30; // Oluþturulacak düþman sayýsý
    public Transform spawnNoktasi; // Düþmanlarýn oluþturulacaðý spawn noktasý
    public float spawnAlanGenislik = 10f; // Düþmanlarýn oluþturulacaðý alan geniþliði

    void Start()
    {
        DusmanlariOlustur();
    }

    void DusmanlariOlustur()
    {
        for (int i = 0; i < dusmanSayisi; i++)
        {
            Vector3 randomPozisyon = GetRandomSpawnPosition();
            Instantiate(dusmanPrefab, randomPozisyon, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        // Rastgele bir konum üret ve spawn alanýna sýðdýr.
        float randomX = Random.Range(-spawnAlanGenislik / 2f, spawnAlanGenislik / 2f);
        float randomZ = Random.Range(-spawnAlanGenislik / 2f, spawnAlanGenislik / 2f);

        Vector3 randomPozisyon = new Vector3(randomX, 0f, randomZ) + spawnNoktasi.position;
        return randomPozisyon;
    }
}