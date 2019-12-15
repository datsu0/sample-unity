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
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.position = new Vector3(0, 0, 0);
        GameObject lightGameObject = new GameObject("Directional Light");
        lightGameObject.AddComponent<Light>();
        lightGameObject.transform.position = new Vector3(0,1,0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
