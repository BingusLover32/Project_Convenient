using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public bool tillactivated = false;

    public Transform tillMarker = null;
    public Transform defaultMarker = null;
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tillactivated == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, tillMarker.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, defaultMarker.position, speed * Time.deltaTime);
        }
    }
}
