using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    public string calc;
    public float num1;
    public float num2;
    private float result;

    // Start is called before the first frame update
    void Start()
    {
        if (calc == "sum")
        {
            result = num1 + num2;
            Debug.Log($"{num1} + {num2} = {result}");
        }
        else if (calc == "subtraction") 
        {
            result = num1 - num2;
            Debug.Log($"{num1} - {num2} = {result}");
        }
        else if (calc == "product")
        {
            result = num1 * num2;
            Debug.Log($"{num1} * {num2} = {result}");
        }
        else if (calc == "division")
        {
            result = num1 / num2;
            Debug.Log($"{num1} / {num2} = {result}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
