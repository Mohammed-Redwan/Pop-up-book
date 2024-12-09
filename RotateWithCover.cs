using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithCover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 && Middel.currentAngel < 180) {
            transform.Rotate(Vector3.up, Time.deltaTime * Middel.rotateSpeed, Space.Self);
        }
        if (Input.GetAxisRaw("Horizontal") < 0 && Middel.currentAngel > 0) {
            transform.Rotate(Vector3.up, -Time.deltaTime * Middel.rotateSpeed, Space.Self);
        }
    }
}
