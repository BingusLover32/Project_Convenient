using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class handslot : MonoBehaviour, IDropHandler
{

    public GameManager gm;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
           

        }

    }
}
