using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public GameObject item;


    void Update()
    {
        item.GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
    }
}
