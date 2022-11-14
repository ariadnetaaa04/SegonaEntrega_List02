using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age >= 18)
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age");
        }
        else
        {
            Debug.Log($"Hello, you are {age} years old, so you are NOT of legal age");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
