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
    public GameObject rotSquare;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switchesText.text = numSwitches.ToString();
    }

    public void OnMouseUp()
    {
        if (numSwitches < 9)
        {
            //rotSquare.transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime * 180f);
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
