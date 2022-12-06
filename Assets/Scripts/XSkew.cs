using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSkew : MonoBehaviour
{
    public GameObject cube;
    private Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        scaleChange = new Vector3(+0.11f, 0.00f, 0.00f);
        cube.transform.localScale += scaleChange;
    }
}
