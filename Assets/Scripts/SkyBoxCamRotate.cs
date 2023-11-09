using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class SkyBoxCamRotate : MonoBehaviour
{
    public static class AxisInput
    {
        public const string Horizontal = "Horizontal";
        public const string Vertical = "Vertical";
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = Input.GetAxisRaw(AxisInput.Horizontal) * 5.0f;
        transform.Rotate(0, 0.05f, 0);
       
    }
}