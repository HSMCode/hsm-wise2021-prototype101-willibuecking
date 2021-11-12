using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeDebug : MonoBehaviour
{
    int count = 1;
    bool spamInitComplete = false;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Igor, it´s Alive.");
        StartCoroutine(SpamInit());       
    }

    IEnumerator SpamInit()
    {
        int countdown = 5;
        int checkCountdown = 3;
        yield return new WaitForSeconds(3);
        Debug.Log("Checking Console readability.");
        yield return new WaitForSeconds(1);
        while(checkCountdown > 0)
        {
            Debug.Log(".");
            yield return new WaitForSeconds(1);
            checkCountdown = checkCountdown - 1;
        }
        Debug.LogWarning("Your Console is too empty.");
        yield return new WaitForSeconds(2);
        Debug.Log("Automatic Console-Spamming Mechanism engaged.");
        yield return new WaitForSeconds(2);
        while(countdown > 0)
        {
            Debug.LogWarning("Starting Spam in " + countdown);
            yield return new WaitForSeconds(1);
            countdown = countdown - 1;
        }
        spamInitComplete = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if (spamInitComplete == true)
        {

            if (count < 500)
            {
                Debug.Log("This message has already been printed " + count + " times");
                count = count + 1;
            }
            else if (count == 500)
            {
                Debug.Log("This is the 500th print.");
                count = count + 1;
            }
            else if (count == 501)
            {
                StartCoroutine(SpamExit());
                count = count + 1;
            }
        }
    
    }

    IEnumerator SpamExit()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Spamming Complete.");
        yield return new WaitForSeconds(1);
        Debug.LogError("Your console is too full to read anything, please consider not having it spammed.");
        yield return new WaitForSeconds(3);
        Debug.Log("Shutting Down");
        yield return new WaitForSeconds(1);
        Debug.Log("Goodbye");
    }
}
