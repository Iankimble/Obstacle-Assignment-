using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_Comp_Custom : MonoBehaviour
{
    [Header("Custom object Rotation Controls")]

    [SerializeField]
    [Tooltip("The axis around which the gameObject is rotating")]
    private Vector3 rotationAxis = Vector3.up;

    [Tooltip("The speed at which the gameObject is rotaitng.")]
    [SerializeField]
    private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
