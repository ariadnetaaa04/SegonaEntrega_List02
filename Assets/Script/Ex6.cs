using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    public float distanceTraveled;
    public float totalDistance;
    public float result;

    // Start is called before the first frame update
    void Start()
    {
        if (distanceTraveled >= totalDistance)
        {
            Debug.Log($"Congratulations! You have completed the total distance");
        }
        else
        {
            result = totalDistance - distanceTraveled;
            Debug.Log($"“Oh… You still have {result} meters left to complete the total distance.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
