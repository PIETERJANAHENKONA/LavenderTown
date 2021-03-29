using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PivotDoor : MonoBehaviour
{
    protected bool levelSucceeded = false;
    protected float openDoorSpeed = -0.5f;
    public bool opendoor;
    public Boxes newBox ;
    private bool stopOpeningtheDoor = false;
    public int doorAngle = 0;






    // Start is called before the first frame update
    void Start()
    {

        newBox = gameObject.AddComponent<Boxes>();




    }

    // Update is called once per frame
    void Update()
    {
        opendoor = newBox._OpenTheDoor;

        if (stopOpeningtheDoor == false)
        {
            if (opendoor == true)
            {
                OpenDoor();
            }

        }
       




    }

    public void OpenDoor()
    {
       
        transform.Rotate(0, 0, openDoorSpeed);

        doorAngle++;

        if (doorAngle == 280)
        {
            stopOpeningtheDoor = true;
        }
    }
}
