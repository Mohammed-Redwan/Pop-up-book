using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnleftCover : MonoBehaviour
{
    private float currentAngel;
    private float numOfOpject = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxisRaw("Horizontal") > 0 && Middel.currentAngel > 135 && currentAngel < 90 * numOfOpject)
        {
            currentAngel += Time.deltaTime * Middel.rotateSpeed;
            transform.Rotate(Vector3.right, Time.deltaTime * Middel.rotateSpeed, Space.World);
        }

        if (Input.GetAxisRaw("Horizontal") < 0 && currentAngel > 0)
        {
            currentAngel -= Time.deltaTime * Middel.rotateSpeed;
            transform.Rotate(Vector3.left, Time.deltaTime * Middel.rotateSpeed, Space.World);



        }
    }
}
