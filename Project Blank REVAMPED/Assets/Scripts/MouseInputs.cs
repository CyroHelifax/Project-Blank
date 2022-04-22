using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Left Click
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse 0 - Left Click");
        }
          // Right Click
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse 1 - Right Click");
        }
          // Middle Click
        if(Input.GetMouseButtonDown(2))
        {
            Debug.Log("Mouse 2 - Middle Click");
        }
          // Extra Click
        if(Input.GetMouseButtonDown(3))
        {
            Debug.Log("Mouse 3 - Extra0 Click");
        }
          // Extra 1 Click
        if(Input.GetMouseButtonDown(4))
        {
            Debug.Log("Mouse 3 - Extra1 Click");
        }
    }
}
