using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingLight : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        
        // simple bounce between locations.
        if(transform.position.x > 3 || transform.position.x < -3)
        {
            moveSpeed = -moveSpeed;
        }
    }
}
