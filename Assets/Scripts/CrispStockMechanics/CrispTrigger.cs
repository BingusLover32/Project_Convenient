using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrispTrigger : MonoBehaviour
{
    public GameObject interactUI;
    public GameObject crispstocktrigger;
    public GameObject stockcrispUI;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            interactUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                stockcrispUI.SetActive(true);
                transform.position = new Vector3(1000, 0, 5);

            }

        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }
}
