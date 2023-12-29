using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dusmanPrefab; // Olu�turulacak d��man prefab'�
    public int dusmanSayisi = 30; // Olu�turulacak d��man say�s�
    public Transform spawnNoktasi; // D��manlar�n olu�turulaca�� spawn noktas�
    public float spawnAlanGenislik = 10f; // D��manlar�n olu�turulaca�� alan geni�li�i

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
        // Rastgele bir konum �ret ve spawn alan�na s��d�r.
        float randomX = Random.Range(-spawnAlanGenislik / 2f, spawnAlanGenislik / 2f);
        float randomZ = Random.Range(-spawnAlanGenislik / 2f, spawnAlanGenislik / 2f);

        Vector3 randomPozisyon = new Vector3(randomX, 0f, randomZ) + spawnNoktasi.position;
        return randomPozisyon;
    }
}