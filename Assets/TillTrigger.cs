using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TillTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stinky Person")
        {
            Debug.Log("Customer is here");
        }
        if (other.tag == "Stinky Person")
        {
            Debug.Log("Player is here");
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Stinky Person")
        {
            Debug.Log("Customer left");
        }

        if (other.tag == "Stinky Person")
        {
            Debug.Log("Player left");
        }
    }
}
