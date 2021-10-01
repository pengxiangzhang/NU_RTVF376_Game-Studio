using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isHit;
 
    void Start()
    {
      
        isHit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Floor") && !isHit)
        {
            isHit = true;
            Debug.Log("Pin has fallen");
        }
    }
}
