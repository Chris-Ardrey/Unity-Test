using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    // Codes try again to pop-up after 10 button presses 

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
            theSwitch.transform.Rotate(0, 0, 0);
            theSwitch.GetComponent<BoxCollider2D>().enabled = false;
            totCount = 0;
        }
    }
}
