using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviorScript : MonoBehaviour
{
    // built in functions called in order:

    // Called first is Awake:
    void Awake ()
    {
        // Called before anything else.
        // Awake can be done before objects are initialized in the scene
        // Initialize variables/components
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame, dependent on fps
    void Update()
    {
        
    }

    // Set a set time, every .02 seconds, for example (to be consistent)
    void FixedUpdate ()
    {
        // runs about 0.02 seconds
    }

    // Called right at the end of the frame. Good to wait if other things are relied on
    void LateUpdate ()
    {
        // for example, camera moves to follow as the person moves in the Update () function
    }

    // two non-ordered functions:
    // Enable/Disable

    // Disable the component, then the scripts are also enabled/disabled

    // Called on a single first frame
    void OnEnable ()
    {

    }

    void onDisable ()
    {
        
    }
}
