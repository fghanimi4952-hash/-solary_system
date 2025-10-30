using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //declare a variable to select the rotation target
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // Rotate Around the fast parameter target position 
        //Rotation Around need parameter about the axis or rotation
        //Rotate Around parameter needed is the speed of roatation 

        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime); 

    }
}
