using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTest : MonoBehaviour
{

    public int myFirstInteger = 10;

    public int mySecondInteger = 20;

    public int myThirdInteger;

	public GameObject myGameObject;

	public float myFirstFloat = 10.5f;

	public float mySecondFloat = 2665.5f;

	public string myFirstText = "Mein erster Text";

	public string messageShorter = "Das ist meine erste Variable des Typs";

	public bool myFirstBool;


    // Start is called before the first frame update
    void Start()
    {

        
		// Debug.Log(messageShorter + " float :" + myFirstFloat);
		// Debug.Log(messageShorter + " int: " + myFirstInteger);
		// Debug.Log(messageShorter + " bool: " + myFirstBool);
		// Debug.Log(messageShorter + " string: " + myFirstText);

		myThirdInteger = myFirstInteger + mySecondInteger;
	    Debug.Log(myThirdInteger);

		myThirdInteger += myFirstInteger;
		Debug.Log(myThirdInteger);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
