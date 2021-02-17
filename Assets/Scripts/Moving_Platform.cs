using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    private void Update()
    {
           
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.SetParent(null);
        }
    }
}
