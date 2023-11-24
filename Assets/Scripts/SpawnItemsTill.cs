using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItemsTill : MonoBehaviour
{
    public GameObject itemPrefab;

    public int iterationCount = 5;

    public void ItemSpawn()
    {
        StartCoroutine(SpawnItems());
    }
 

    public IEnumerator SpawnItems()
    {
        Debug.Log("function called");
        for (int i = 0; i < iterationCount; i++)
        {
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }

      
    }


}
