using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    Rigidbody rBody;
    public bool startbelt = true;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (startbelt == true)
        {
            Vector3 pos = rBody.position;
            rBody.position += Vector3.right * speed * Time.fixedDeltaTime;
            rBody.MovePosition(pos);
        }
    }
        
    
}
