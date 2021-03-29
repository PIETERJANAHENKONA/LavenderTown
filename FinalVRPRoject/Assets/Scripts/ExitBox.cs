using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class ExitBox : MonoBehaviour
{
    public GameObject XRRIG;

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == XRRIG.gameObject)
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Game Ends");
        }
    }
    
}
