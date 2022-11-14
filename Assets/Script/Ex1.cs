using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public float num;
    // Start is called before the first frame update
    void Start()
    {
      if (num > 0)
        {
            Debug.Log($"Number {num} is positive");
        }  
      else if (num < 0)
        {
            Debug.Log($"Number {num} is negative");
        }
      else
        {
            Debug.Log($"It's number {num} ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
