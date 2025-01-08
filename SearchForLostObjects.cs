using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForLostObjects : MonoBehaviour
{

    private List<string> missingObjects = new List<string> { "Key", "Gold", "Doll", "Letter" };
    private int remainingAttempts = 5;
    private int foundObjects = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game of Missing Objects is started!");

        
        PlayGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayGame()
    {
        while (remainingAttempts > 0 && missingObjects.Count != 0)
        {
            string guessedObject = GuessTheObject();
            CheckObject(guessedObject);
        }


        if (foundObjects == 4)
        {
            Debug.Log("Congratulations! You've found all the missing objects!");
        }
        else
        {
            Debug.Log("Game Over! You ran out of attempts.");
        }
    }

    string GuessTheObject()
    {
        Debug.Log("Guess the missing object:");

        // Generate a random number between 0 and 1
        float randomValue = Random.Range(0f, 1f);

        string guess;

        if (randomValue <= 0.5f)
        {
            // Pick a random object from the list
            guess = missingObjects[Random.Range(0, missingObjects.Count)];
            Debug.Log("The user chose: " + guess);
        }
        else
        {
            guess = "Shampoo!";
            Debug.Log("The user chose: Shampoo!");
        }


        return guess;
    }



    void CheckObject(string playerGuess)
    {
        
        bool objectFound = false;
        
        foreach (string missingObject in missingObjects)
        {
            if (playerGuess.Equals(missingObject))
            {
                Debug.Log($"You found the {missingObject}!");
                foundObjects++;
                missingObjects.Remove(missingObject);
                objectFound = true;
                break;
            }
        }

        if (!objectFound)
        {
            remainingAttempts--;
            Debug.Log($"That object is not on the list. Remaining attempts: {remainingAttempts}");
        }
        else
        {
            Debug.Log($"Objects found: {foundObjects}/{4}. Remaining attempts: {remainingAttempts}");
        }
    }


}
