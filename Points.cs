using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Transform target;
    public Vector3 maindDistance;
    // Start is called before the first frame update
    void Start()
    {
        maindDistance = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + maindDistance;
    }
}
