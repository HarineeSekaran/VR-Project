using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject cube;
    
    private void OnCollisionEnter(Collision Collision)
    {
        cube.SetActive(true);
        this.gameObject.SetActive(false);

    }
}
