using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boxes : MonoBehaviour

{
    public static Dictionary<string, bool> CompletedPuzzels;

    protected static bool _openTheDoor;

    public bool _OpenTheDoor
    {
        get
        {
            return _openTheDoor;


        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _openTheDoor = false;
        CompletedPuzzels = new Dictionary<string, bool>();

        CompletedPuzzels.Add("RedBoxSolved", false);
        CompletedPuzzels.Add("BlueBoxSolved", false);
        CompletedPuzzels.Add("YellowBoxSolved", false);
        CompletedPuzzels.Add("AquaBoxSolved", false);
        CompletedPuzzels.Add("PurpleBoxSolved", false);

        CheckIfAllPuzzelsSolved();



    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collider)
    {
        string objectName = gameObject.name;

        string BoxColor = objectName.Substring(0,name.Length-1);

        if (collider.gameObject.name == BoxColor+"A")
        {

            print(BoxColor+"Puzzel solved!");

            CompletedPuzzels[BoxColor + "Solved"] = true;

            if (CheckIfAllPuzzelsSolved() == true)
            {
                print("All Puzzels solved!");

                if (_openTheDoor==false)
                {
                    _openTheDoor = true;

                }


            }



        }


    }
    private void OnCollisionExit(Collision collision)
    {
        string objectName = gameObject.name;

        string BoxColor = objectName.Substring(0, name.Length - 1);

        if (collision.gameObject.name == BoxColor + "A")
        {
            print(BoxColor + "Puzzel Unsolved!");

            CompletedPuzzels[BoxColor + "Solved"] = false;


        }

    }
    protected bool CheckIfAllPuzzelsSolved()
    {
        bool AllSolved = false;
        int AmountOfSolvedPuzzels = 0;

        foreach (var puzzel in CompletedPuzzels)
        {
            print(puzzel.Key + " " + puzzel.Value);

            if (puzzel.Value == true)
            {
                AmountOfSolvedPuzzels++;
            }


        }

        if (AmountOfSolvedPuzzels == 5)
        {
            AllSolved = true;

            
        }

        return AllSolved;

    }
}
