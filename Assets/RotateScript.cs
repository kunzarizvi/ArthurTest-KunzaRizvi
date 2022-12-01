using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnMouseDrag(){
        Debug.Log(Input.mousePosition);
        transform.localRotation = Quaternion.Euler(Input.mousePosition.y*speed,-1*Input.mousePosition.x*speed, 0);
    }
}
