using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoorTeacher : MonoBehaviour
{
    public GameManager gameManager;

    public void OpenDoor()
    {
        transform.Translate(0f,6f,0f);
        Debug.Log("Door is Open");
    }
}
