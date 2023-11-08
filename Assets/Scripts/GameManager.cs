using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameManager gm;

    public int stocked;
    public GameObject crispstockUI;
    public GameObject drinkstockUI;

    public void Update()
    {
        if (stocked == 8)
        {
            crispstockUI.SetActive(false);
            drinkstockUI.SetActive(false);
            stocked = stocked - 8;
        }
    }
}
