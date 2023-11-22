using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TillTrigger : MonoBehaviour
{

    SpawnItemsTill spawnItemsTill;

    void Start()
    {
        spawnItemsTill = GameObject.FindGameObjectWithTag("SpawnItemsTill").GetComponent<SpawnItemsTill>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Customer")
        {
            Debug.Log("Customer is here");
        }
        if (other.tag == "Player")
        {
            spawnItemsTill.ItemSpawn();
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Customer")
        {
            Debug.Log("Customer left");
        }

        if (other.tag == "Player")
        {
            Debug.Log("Player left");
        }
    }
}
