using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    Vector3 prevPos = Vector3.zero;
    Vector3 posDelta = Vector3.zero;
    Collider boxcollider;
    void Start()
    {
        boxcollider = GetComponent<Collider>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0) &&  boxcollider.isTrigger == true){
            posDelta= Input.mousePosition - prevPos;
            if (Vector3.Dot(transform.up,Vector3.up)>=0){
                transform.Rotate(transform.up,-Vector3.Dot(posDelta, Camera.main.transform.right), Space.World);
            }  
            else{
                transform.Rotate(transform.up,Vector3.Dot(posDelta, Camera.main.transform.right), Space.World);
            }
            
            transform.Rotate(Camera.main.transform.right, Vector3.Dot(posDelta,Camera.main.transform.up), Space.World);
        }
        prevPos = Input.mousePosition;

    }

    void OnMouseDown(){
        boxcollider.isTrigger = true;    
    }
    void OnMouseUp(){
        boxcollider.isTrigger = false;
    }
}
