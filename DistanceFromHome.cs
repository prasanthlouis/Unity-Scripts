using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

    int numberOfSteps = 1;
    Vector2 homeLocation = new Vector2(2, 3);
    Vector2 playerLocation = new Vector2(5, 1);
    bool gameOver;

    // Use this for initialization
    void Start () {
        PrintWelcomeMessage();
    }

    void PrintWelcomeMessage()
    {
        print("Welcome to the game!");
        print("Starting it up");
        print("HomeLocation is " + homeLocation);
        print("PlayerLocation is " + playerLocation);
    }

    void IncreaseNumberOfSteps()
    {
        numberOfSteps++;
    }


    void PrintUpdate()
    {
        Vector2 distance = homeLocation - playerLocation;
        gameOver = distance.magnitude < 1;
        if (gameOver)
            print("You've reached home");
        else
        {
            print("After " + numberOfSteps + " steps you are " + distance.magnitude + " meters away from home!");
            IncreaseNumberOfSteps();
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (gameOver)
            return;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerLocation += Vector2.down;
            PrintUpdate();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerLocation += Vector2.up;
            PrintUpdate();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerLocation += Vector2.left;
            PrintUpdate();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerLocation += Vector2.right;
            PrintUpdate();
        }
    }
}
