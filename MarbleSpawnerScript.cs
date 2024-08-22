using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleSpawnerScript : MonoBehaviour
{
    public GameObject completeMarblePrefab; // Reference to the CompleteMarble prefab
    public int numberOfMarbles = 10; // The number of marbles to spawn

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfMarbles; i++)
        {
            // Calculate a random position for each marble (this can be adjusted as needed)
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), (Random.Range(1f, 5f)), Random.Range(-5f, 5f));

            // Instantiate the prefab at the calculated position
            Instantiate(completeMarblePrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

