using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createrObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent(typeof(RotateSample));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
