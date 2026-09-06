using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManagerB : MonoBehaviour
{
    public GameObject[] animalPrefab;

    

    private float spawnRageX = 20.0f;
    private float spawnRagex2 = 30.0f;
    private float spawnPosZ = 20.0f;
    private float spawnPosZ2 = 16.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
        
    }

    void SpawnRandomAnimal()
    {

        // Random generate animal indx and spwan position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRageX, spawnRageX), 0, spawnPosZ);
        Vector3 spawnPossideR = new Vector3(spawnRagex2,0,Random.Range(5,spawnPosZ2));
        Vector3 spawnPossideL = new Vector3(-spawnRagex2,0,Random.Range(5,spawnPosZ2));

        int animalIndex = Random.Range(0, animalPrefab.Length);
        int animalIndex2 = Random.Range(0, animalPrefab.Length);
        int animalIndex3 = Random.Range(0, animalPrefab.Length);

        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        Instantiate(animalPrefab[animalIndex2], spawnPossideR, Quaternion.Euler(0,-90,0));
        Instantiate(animalPrefab[animalIndex3], spawnPossideL, Quaternion.Euler(0,90,0));

    }
}
