using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false;
    public int totCount;
    public Button myButton;
    public GameObject theSwitch; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        if (totCount < 9)
        {
            totCount++;
            a = false;
            canvas.enabled = false;
            myButton.enabled = true;
            theSwitch.SetActive(true);
        }
        else 
        {
            a = true;
            canvas.enabled = true;
            myButton.enabled = false;
            theSwitch.SetActive(false);
            totCount = 0;
        }
    }
}
