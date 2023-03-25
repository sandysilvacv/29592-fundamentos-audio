using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 changePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += changePosition;
    }
}
