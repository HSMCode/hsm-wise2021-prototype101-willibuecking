using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRollerScript : MonoBehaviour
{
    private bool numbersEntered = false;    //Storing the state of the lucky numbers

    public int[] luckyNumbers;              //players lucky numbers 
        
    private int recentThrow;                //used for storing the last generated dice-value

    private int points = 10;                //used for storing the players score

    private bool messaged = false;          //used to check, if the opening-message has already been printed

    private bool hit;

    void Start()
    {
        luckyNumbers = new int[3];
        Debug.Log("Welcome to the Dice-Game. Please Input your lucky numbers (between 1 and 20) on the right and press Space to continue.");
        Debug.Log("You start with 10 points, each time the dice hits one of your lucky numbers, you win 5 points, if it doesn�t, you lose 1.");

        //Put in the following block for testing so you don�t need to manually enter numbers at every run
        /*
        luckyNumbers[0] = 3;
        luckyNumbers[1] = 5;
        luckyNumbers[2] = 8;
        */
    }
    void Update()
    {
        if ((luckyNumbers[0] > 20) | (luckyNumbers[1] > 20) | (luckyNumbers[2] > 20)) //check if the lucky numbers are in the correct range
        {
            Debug.Log("Please enter numbers between 1 and 20.");
            numbersEntered = false;
            luckyNumbers = new int[3];
            messaged = false;
        }
        if (luckyNumbers[0] > 0 & luckyNumbers[1] > 0 & luckyNumbers[2] > 0)  //check if the lucky numbers have been set
        {
            numbersEntered = true;
        }


        if(numbersEntered == true)  //if the numbers have been entered, the game starts
        {
            if(messaged == false)   //check to see if the greeting-message has already been printed, if not, do so
            {
                Debug.Log("Press Space to roll dice.");
                messaged = true;    //set to true to stop consecutive printing of greetings
            }
            else if(Input.GetKeyDown(KeyCode.Space))    //if space bar is pressed down, dice is thrown
            {
                recentThrow = Random.Range(1, 21);      //the number rolled is stored in recentThrow
                Debug.Log("You rolled a " + recentThrow);   //inform player of number rolled
                foreach(int number in luckyNumbers)     //check if rolled number is one of the lucky numbers
                {
                    if (number == recentThrow)
                    {
                        hit = true;     //if yes, set flag to true
                    }
                }
                if(hit)         //if a lucky number was hit (flag set to true), add 5 points to score, inform player, set flag to false for the next round
                {
                    points += 5;
                    Debug.Log("Hit! You gain 5 points");
                    hit = false;
                }
                else            //if no lucky number was hit, deduct 1 point, inform player
                {
                    points -= 1;
                    Debug.Log("Miss. You loose 1 point");
                }
                Debug.Log("Score: " + points);      //print current score
                //messaged = false;         //activate this if you want to remind the player to press space after each roll
            }
        }
        if(points <= 0)     //check if loose-condition is met, if so, inform player, reset luckyNumbers and score, reset greeting-flag
        {
            Debug.Log("You lost.");
            Debug.Log("To play again, enter your lucky numbers.");
            luckyNumbers = new int[3];
            numbersEntered = false;
            points = 10;
            messaged = false;       //comment this out to not greet the player again
        }
        else if(points >= 20)       //check if win condition is met, if so, inform player, reset luckyNumbers and score, reset greeting-flag
        {
            Debug.Log("You win.");
            Debug.Log("To play again, enter your lucky numbers.");
            luckyNumbers = new int[3];
            numbersEntered = false;
            points = 10;
            messaged = false;       //comment this out to not greet the player again
        }
    }
}
