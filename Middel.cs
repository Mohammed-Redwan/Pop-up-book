using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class Middel : MonoBehaviour
{
    public static float currentAngel;
    public static float rotateSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 && currentAngel < 180) {
            currentAngel += Time.deltaTime * rotateSpeed;
            transform.Rotate(Vector3.back, Time.deltaTime * rotateSpeed);
        }

        if (Input.GetAxisRaw("Horizontal") < 0 && currentAngel > 0) {
            currentAngel -= Time.deltaTime * rotateSpeed;
            transform.Rotate(Vector3.back, -Time.deltaTime * rotateSpeed);
        }
    }
}
