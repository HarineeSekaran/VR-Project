using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    public GameObject cube;
    public float startTime=0f;
    void Start()
    {
        Invoke("CubeActive", startTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CubeActive()
    {
        cube.SetActive(true);
        Invoke("CubeInactive", .3f);
    }
    void CubeInactive()
    {
        cube.SetActive(false);
        Invoke("CubeActive", .3f);
    }
}
