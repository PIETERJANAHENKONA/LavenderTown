using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;
    
    // Start is called before the first frame update
    public void DoClick()
    {
        Debug.Log(message: "Button clicked");
        FindObjectOfType<Canvas>().enabled = false;

        gameManager.StartGame();
    }

}
