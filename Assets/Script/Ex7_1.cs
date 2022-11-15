using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7_1 : MonoBehaviour
{
    public string letter;
    // Start is called before the first frame update
    void Start()
    {
    if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log($"The letter {letter} is a vowel.");
        }
        else
        {
            Debug.Log($"The letter {letter} is a consonant");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
