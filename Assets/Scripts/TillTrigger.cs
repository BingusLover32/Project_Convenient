using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TillTrigger : MonoBehaviour
{

    SpawnItemsTill spawnItemsTill;

    MoveCamera moveCamera;
    public int numberofpeople = 2;

    public bool startTill = false;

     
    void Start()
    {
        spawnItemsTill = GameObject.FindGameObjectWithTag("SpawnItemsTill").GetComponent<SpawnItemsTill>();
        moveCamera= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MoveCamera>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Customer")
        {
            numberofpeople++;
        }
        if (other.tag == "Player")
        {
            numberofpeople++;
        }
       

    }

    void Update()
    {
        if (numberofpeople == 2)
        {
            spawnItemsTill.ItemSpawn();
            numberofpeople = 0;
            moveCamera.tillactivated = true;
        }
       

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Customer")
        {
            moveCamera.tillactivated = false;
        }

        if (other.tag == "Player")
        {
            numberofpeople = 0;
        }
    }
}
