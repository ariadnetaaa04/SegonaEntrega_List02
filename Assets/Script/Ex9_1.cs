using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9_1 : MonoBehaviour
{
    public int candy;
    public int people;
    private int result;
    private int rest;

    // Start is called before the first frame update
    void Start()
    {
        result = candy / people;
        rest = candy % people;
        Debug.Log($"There is {people} persons, everyone got {result} candies each. There is {rest} candies left");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
