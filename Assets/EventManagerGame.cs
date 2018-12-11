using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class EventManagerGame : MonoBehaviour {

    public GameObject hunger;
    public GameObject health;
    public GameObject happy;
    public GameObject energy;

    public Text continueButton;
    public Text saveButton;
    public Text saveAndExitButton;
    public Text exitButton;

    public GameObject menu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    public void OnPointerEnter(string buttonName)
    {
        switch (buttonName)
            {
                case ("hunger"):
                    hunger.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case ("health"):
                    health.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case ("happy"):
                    happy.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case ("energy"):
                    energy.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case ("menu"):
                    menu.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;            
            }
    }


    public void OnPointerExit(string buttonName)
    {
        switch (buttonName)
            {
                case ("hunger"):
                    hunger.gameObject.transform.localScale = new Vector3(1, 1, 1);
                    break;
                case ("health"):
                    health.gameObject.transform.localScale = new Vector3(1, 1, 1);
                    break;
                case ("happy"):
                    happy.gameObject.transform.localScale = new Vector3(1, 1, 1);
                    break;
                case ("energy"):
                    energy.gameObject.transform.localScale = new Vector3(1, 1, 1);
                    break;
                case ("menu"):
                    menu.gameObject.transform.localScale = new Vector3(1, 1, 1);
                    break;
            }

    }

    public void MenuOnPointerEnter(string buttonName)
    {
        switch (buttonName)
        {
            case ("continue"):
                continueButton.fontSize = 35;
                break;
            case ("save"):
                saveButton.fontSize = 35;
                break;
            case ("saveAndExit"):
                saveAndExitButton.fontSize = 35;
                break;
            case ("exit"):
                exitButton.fontSize = 35;
                break;
        }
    }

    public void MenuOnPointerExit(string buttonName)
    {
        switch (buttonName)
        {
            case ("continue"):
                continueButton.fontSize = 30;
                break;
            case ("save"):
                saveButton.fontSize = 30;
                break;
            case ("saveAndExit"):
                saveAndExitButton.fontSize = 30;
                break;
            case ("exit"):
                exitButton.fontSize = 30;
                break;
        }
    }
}
