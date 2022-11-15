using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex10_1 : MonoBehaviour
{
    public int mult = 2;
    private int i;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
             result = mult * i;
            Debug.Log($"{mult} * {i} = {result}");
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
