using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyorbeltstop : MonoBehaviour
{

  
    ConveyorBelt conveyorBelt;
    void Start()
    {
        conveyorBelt = GameObject.FindGameObjectWithTag("Conveyorbelt").GetComponent<ConveyorBelt>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Item")
        {
            conveyorBelt.startbelt = false;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            conveyorBelt.startbelt = true;
        }
    }


}
