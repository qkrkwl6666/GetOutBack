using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{

    private SphereCollider sphereCollider;
    

    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();

    }

    void Update()
    {
        if (sphereCollider != null)
        {
  
            Shader.SetGlobalVector("_Object", transform.position + Vector3.up * sphereCollider.radius);
        }
    }
}