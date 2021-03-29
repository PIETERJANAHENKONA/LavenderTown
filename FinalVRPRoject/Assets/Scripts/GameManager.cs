using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.AI;



public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    bool enableLocomotion = false;
    float timerReleaseTeachers;
    bool startTimer = false;
    bool timerHasAlreadyStarted = false;
    public GameObject varGameObject;
    public GameObject Ai;

   
    public OpenDoorTeacher doorTeacher;

    void Start()
    {
        timerReleaseTeachers = 180.0f;
        varGameObject.GetComponent<TeleportationProvider>().enabled = false;
        varGameObject.GetComponent<ActionBasedContinuousMoveProvider>().enabled = false;
        Ai.SetActive(false);
    }
    void Update()
    {
        //timer code
        if (timerHasAlreadyStarted == false)
        {
            if (startTimer == true)
            {
                timerReleaseTeachers -= Time.deltaTime;
                if (timerReleaseTeachers <= 0)
                {
                    doorTeacher.OpenDoor();

                    timerHasAlreadyStarted = true;
                    Debug.Log("Teachers are released!");
                    Ai.SetActive(true);

                }
            }
        }
        
       
       
    }
    // Start is called before the first frame update
    public void StartGame()
    {

        if (enableLocomotion == false)
        {
           varGameObject.GetComponent<TeleportationProvider>().enabled = true;
           varGameObject.GetComponent<ActionBasedContinuousMoveProvider>().enabled = true;

            startTimer = true;

        }
    }

    // Update is called once per frame
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}
