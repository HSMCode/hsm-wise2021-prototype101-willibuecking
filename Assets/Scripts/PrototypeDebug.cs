using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypeDebug : MonoBehaviour
{
    int Count = 1;
    bool SpamInitComplete = false;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Igor, it´s Alive.");
        StartCoroutine(SpamInit());       
    }

    IEnumerator SpamInit()
    {
        int Countdown = 5;
        int CheckCountdown = 3;
        yield return new WaitForSeconds(3);
        Debug.Log("Checking Console readability.");
        yield return new WaitForSeconds(1);
        while(CheckCountdown > 0)
        {
            Debug.Log(".");
            yield return new WaitForSeconds(1);
            CheckCountdown = CheckCountdown - 1;
        }
        Debug.LogWarning("Your Console is too empty.");
        yield return new WaitForSeconds(2);
        Debug.Log("Automatic Console-Spamming Mechanism engaged.");
        yield return new WaitForSeconds(2);
        while(Countdown > 0)
        {
            Debug.LogWarning("Starting Spam in " + Countdown);
            yield return new WaitForSeconds(1);
            Countdown = Countdown - 1;
        }
        SpamInitComplete = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if (SpamInitComplete == true)
        {

            if (Count < 500)
            {
                Debug.Log("This message has already been printed " + Count + " times");
                Count = Count + 1;
            }
            else if (Count == 500)
            {
                Debug.Log("This is the 500th print.");
                Count = Count + 1;
            }
            else if (Count == 501)
            {
                StartCoroutine(SpamExit());
                Count = Count + 1;
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
