using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_script : MonoBehaviour
{
    public int counter;

    // the prefab the will be called
    public GameObject bonusObject;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        counter--;

        if (counter == -0)
            SpawnBonus();

        void SpawnBonus()
        {


            // Call/ instantiate Prefab
            GameObject.Instantiate(bonusObject, transform);
        }
        //Debug.Log("Pick up message has been recieved.");
    }
}
