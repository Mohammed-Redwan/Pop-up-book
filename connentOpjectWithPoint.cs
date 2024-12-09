using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connentOpjectWithPoint : MonoBehaviour
{
    public Transform target;
    public Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0,0.02f,0);
        
        Debug.Log(transform.position - target.position);
    }
}
