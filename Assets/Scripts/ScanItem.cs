using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanItem : MonoBehaviour
{
    SpawnItemsTill spawnItemsTill;
    MoveCamera moveCamera;

    public int checkitemnumber;

    public GameObject Customer;
    void Start()
    {
        spawnItemsTill = GameObject.FindGameObjectWithTag("SpawnItemsTill").GetComponent<SpawnItemsTill>();
        moveCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MoveCamera>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")

        {
            checkitemnumber++;
            Debug.Log(checkitemnumber);
            Destroy(other);
            other.gameObject.SetActive(false);
            
        }
    }

  


    void Update()
    {
        if (checkitemnumber == 5)
        {
            moveCamera.tillactivated = false;
            Destroy(Customer);
        }


    }
}
