using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticLight : MonoBehaviour
{
    public Transform window;
    public Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - window.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = window.position + distance;
    }
}
