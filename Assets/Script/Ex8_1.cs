using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8_1 : MonoBehaviour
{
    public string month;
    // Start is called before the first frame update
    void Start()
    {
        if (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december")
        {
            Debug.Log($"{month} has 31 days.");
        }
        else if (month == "april" || month == "june" || month == "september" || month == "november")
        {
            Debug.Log($"{month} has 30 days");
        }
        else
        {
            Debug.Log($"{month} has 29 days");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
