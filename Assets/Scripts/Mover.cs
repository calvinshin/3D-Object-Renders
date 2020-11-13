using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        // New position stored as a vector
        // Vector3 newPos = new Vector3(5, 2, -2);

        // moverscript will now update to newPos
        // transform class
        // transform.position = newPos;

        // moves 10 cm every frame
        transform.position += new Vector3(.1f, 0, 0) * Time.deltaTime * moveSpeed;
        // Vector3.one moves it at (1f,1f,1f)
        // MoveSpeed = 0, so doesn't move. If set to 1, it will move.

        transform.position += transform.forward * Time.deltaTime * moveSpeed;

        // If this is 60 fps, runs 60/sec, 30fps -> 30/sec
        // need a way to multiply this by deltatime to keep it constant regardless of fps.
    }

    // Creating a class, will be able to modify this in the inspector.
    public float moveSpeed;
}
