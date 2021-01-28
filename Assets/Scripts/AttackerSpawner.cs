using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabs;
    IEnumerator Start()
    {
        while (spawn)
        {
            int randomAttackerIndex = Random.Range(0, attackerPrefabs.Length);
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            Attacker attacker = Instantiate(attackerPrefabs[randomAttackerIndex], transform.position, Quaternion.identity);
            attacker.transform.SetParent(transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
