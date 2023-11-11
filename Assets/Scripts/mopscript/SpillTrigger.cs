using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillTrigger : MonoBehaviour
{
    public GameObject spillasset;
    public GameObject CleanspillUI;
    public GameObject interactUI;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            interactUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                CleanspillUI.SetActive(true);
                spillasset.SetActive(false);
                transform.position = new Vector3(1000, 0, 5);

            }

        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }

}