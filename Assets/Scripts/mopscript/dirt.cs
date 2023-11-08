using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "binend")
        {
            Destroy(gameObject);
        }
    }
}
