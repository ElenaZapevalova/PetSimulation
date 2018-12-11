using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventManagerMainMenu : MonoBehaviour
{
    public Text newGameButton;
    public Text startButton;
    public Text exitButton;
    public Text exitWithoutLoadButton;
    public Text newGameWithoutLoadButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerEnter(string buttonName)
    {
        switch (buttonName)
        {
            case ("new"):
                newGameButton.fontSize = 30;
                break;
            case ("newWithoutLoad"):
                newGameWithoutLoadButton.fontSize = 30;
                break;
            case ("start"):
               startButton.fontSize = 30;
                break;
            case ("exitWithoutLoad"):
                exitWithoutLoadButton.fontSize = 30;
                break;
            case ("exit"):
                exitButton.fontSize = 30;
                break;
        }


    }
    public void OnPointerExit(string buttonName)
    {
        switch (buttonName)
        {
            case ("new"):
                newGameButton.fontSize = 20;
                break;
            case ("newWithoutLoad"):
                newGameWithoutLoadButton.fontSize = 20;
                break;

            case ("start"):
                startButton.fontSize = 20;
                break;

            case ("exitWithoutLoad"):
                exitWithoutLoadButton.fontSize = 20;
                break;

            case ("exit"):
                exitButton.fontSize = 20;
                break;
        }

    }
}
