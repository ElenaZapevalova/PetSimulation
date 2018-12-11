using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class EventManagerNewGame : MonoBehaviour {

 public GameObject redButton;
    public GameObject orangeButton;
    public GameObject yellowButton;
    public GameObject greenButton;
    public GameObject blueButton;
    public GameObject purpleButton;

    public GameObject playButton;

    private string color;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (color != "")
        {
            increaseSizeColorButton(color);
        }
    }

    public void OnPointerEnter(string buttonName)
    {
        increaseSizeColorButton(buttonName);
    }

    public void OnPointerExit(string buttonName)
    {
        decreaseSizeColorButton(buttonName);

    }

    public void increaseSizeColorButton(string color)
    {
        switch (color)
        {
            case ("red"):
                redButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("orange"):
                orangeButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("yellow"):
                yellowButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("green"):
                greenButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("blue"):
                blueButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("purple"):
                purpleButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
            case ("play"):
                playButton.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                break;
        }
    }

    public void decreaseSizeColorButton(string color)
    {
        switch (color)
        {
            case ("red"):
                redButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("orange"):
                orangeButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("yellow"):
                yellowButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("green"):
                greenButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("blue"):
                blueButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("purple"):
                purpleButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
            case ("play"):
                playButton.gameObject.transform.localScale = new Vector3(1, 1, 1);
                break;
        }
    }

    public void onClickColorButton(string color)
    {
        decreaseSizeColorButton(this.color);
        this.color = color;
    }

}
