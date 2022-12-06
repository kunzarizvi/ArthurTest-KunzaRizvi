using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexSelector : MonoBehaviour
{
    Mesh mesh;
    Vector3 [] vertices;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

    }

    // Update is called once per frame
    void Update()
    {
        vertices = mesh.vertices;
        mesh.RecalculateBounds();
        Debug.Log(vertices[23]);
    }
}
