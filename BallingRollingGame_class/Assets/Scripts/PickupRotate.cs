using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotate : MonoBehaviour
{
       // Update is called once per frame
    void Update()
    {
        //Values to rotate the GameObjects transorm on each axis
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
