using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider))]

public class Switch : MonoBehaviour
{
    
    public int numSwitches;
    public Text switchesText;
    public Canvas canvas;
    public bool a = false;
    public Button myButton;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        switchesText.text = numSwitches.ToString();
    }

    private void OnMouseUp()
    {
        if (numSwitches < 9)
        {
            StartCoroutine(Reset());
            transform.Rotate(0, 0, 90);
            numSwitches++;
            a = false;
            canvas.enabled = false;
            myButton.enabled = true;
        }
        else
        {
            numSwitches = 10;
            a = true;
            canvas.enabled = true;
            myButton.enabled = false;

        }
        
        
    }
    
    IEnumerator Reset()
    {
       yield return new WaitForSeconds(2);
       transform.Rotate(0, 0, 90);
    }

    
}
