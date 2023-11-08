using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaned : MonoBehaviour
{
    public GameObject cleanspillUI;
    public int numberofdirt = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("contact");
        if (collision.gameObject.tag == "dirt")
        {
            
            Debug.Log("contact with dirt");
            AddDirtPoint();
        }
    }

    private void Update()
    {
        if (numberofdirt == 7)
        {
            endcleanspill();
        }
    }
    void endcleanspill()
    {

        cleanspillUI.SetActive(false);
    }

    public void AddDirtPoint()
    {
        numberofdirt++;
    }
}
