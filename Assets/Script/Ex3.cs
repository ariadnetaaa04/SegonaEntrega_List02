using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num % 5 == 0)
        {
            Debug.Log($"This number is divisible by 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
