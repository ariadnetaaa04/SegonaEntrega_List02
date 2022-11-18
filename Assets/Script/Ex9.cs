using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    public bool wantsVegetarianOption;
    // Start is called before the first frame update
    void Start()
    {
       if (!wantsVegetarianOption == true)
        {
            Debug.Log($"Non-vegetarian option coming soon");
        } 
       else
        {
            Debug.Log($"Vegetarian option coming soon");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
