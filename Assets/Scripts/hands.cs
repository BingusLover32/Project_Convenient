using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hands : MonoBehaviour
{
    public GameObject stockingtaskUI;
    public void Update()
    {
        if (transform.childCount == 7)
        {
            Debug.Log("childcount under 9");
            stockingtaskUI.SetActive(false);
        }
    }
}
