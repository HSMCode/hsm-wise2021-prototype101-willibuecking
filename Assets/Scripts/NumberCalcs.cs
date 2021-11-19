using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCalcs : MonoBehaviour
{   

    public int[] myIntegers =  new int[5] { 3, 7, 11, 6, 25 };  //create 5 wholenumber-variables

    public int sum = 0;

    public float result;        //This will be used for calculations later on
    public string ansage = "Die Summe der ersten fünf Variablen dieses Scripts geteilt durch drei ist ";    //This will be some text to make the console-outpur understandable

    // Start is called before the first frame update
    void Start()
    {
        foreach (int i in myIntegers)
        {
            sum += i;
        }

        result = sum/3;     //calculations (sum of 5 integers divided by 3)
 
        Debug.Log(ansage + result);                     //finally print the result

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
