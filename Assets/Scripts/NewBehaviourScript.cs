using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// newbheaviorscript = class
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Initializing...");
        LogLevel();

        string location = "Australia";
        int health = 50;
        // With floats need the f to indicate that this is a flaot
        float moveSpeed = 2.5f;

        bool canMove = true;

        printVariables(location, health, moveSpeed);

        Debug.Log("Printing from Start(), location should still be Australia");
        Debug.Log(location);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LogLevel ()
     {
         int level2 = 20;
         Debug.Log("Level " + level2);
     }




     void Test()
     {

     }

     void printVariables(string text, int numb, float f)
     {
        Debug.Log("Printing called variables");
        Debug.Log(text);
        Debug.Log(numb);
        Debug.Log(f);

        Debug.Log("Updated text in text variable, should not be returned back since this is a void type function");
        text = "New Text";
        Debug.Log("text: " + text);
     }

}
