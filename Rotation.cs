using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotSpeed = 180f;
    protected bool rotate = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(Vector3.forward * (-rotSpeed * Time.deltaTime)); 
        }
     
  
    }

    public void CubeRotate()
    {
        rotate = !rotate;
    }

   
}
