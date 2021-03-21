using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PivotDoor : MonoBehaviour
{
    protected bool levelSucceeded = false;
    protected float openDoorSpeed = -0.1f;
    private int doorangle = 0;

    public Boxes newBox ;

   



    // Start is called before the first frame update
    void Start()
    {

        newBox = gameObject.AddComponent<Boxes>();




    }

    // Update is called once per frame
    void Update()
    {

        if (newBox._OpenTheDoor == true)
        {
            OpenDoor();
        }




    }

    public void OpenDoor()
    {
        if (doorangle < 1400)
        {           
                transform.Rotate(0, 0, openDoorSpeed);

                doorangle++;         
        }
    }
}
