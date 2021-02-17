using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondMovingPlatform : MonoBehaviour
{
    public Transform[] points;
    public float speed = 0;

    private Transform currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        if(points.Length > 0)
        {
            currentTarget = points[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTarget != null)
        { 
           if(Vector3.Distance(transform.position, currentTarget.position)< 0.5f)
            {
                index++;
                if(indexer >= points.Length)
            }
        }
    }
}
