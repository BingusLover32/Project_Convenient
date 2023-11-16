using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillTrigger : MonoBehaviour
{
    public GameObject WhiteboardCamera;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                WhiteboardCamScript.ActivateIt();

            }

        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }

}