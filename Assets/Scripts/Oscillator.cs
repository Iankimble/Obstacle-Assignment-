using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Movement Parameters")]

    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("Movement Positions")]
    public Vector3 startingPostion;
    public Vector3 endingPosition;

    public Vector3 posEnd;
    public Vector3 negEnd;

    private Vector3 direction; 

    // Start is called before the first frame update
    void Start()
    {
        //The direction of movement
        direction = movementAxis.normalized;

        //Precompute positions
        startingPostion = transform.position;

        // This is scalar multiplication
        posEnd = transform.position + (direction * movementDistance);
        negEnd = transform.position - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixUpdate()

    {
        // If we reach the bounds of the movement, reverse the direction vector
        if (Vector3.Distance(transform.position, posEnd) <= 0.01f || Vector3.Distance(transform.position, negEnd) <= 0.01f)
            direction *= -1;

        // Move the platform
        transform.Translate(direction * movementSpeed * Time.deltaTime);   
    }
}
