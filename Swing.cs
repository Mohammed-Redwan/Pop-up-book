using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Transform swing;
    public float swingAngel;
    public Vector3 nextAngel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (RotateOnOpen.inBookAngel > 90 * RotateOnOpen.numOfOpject) {
            swingAngel = Mathf.Sin(Mathf.PI * Time.time * 0.5f);
            transform.rotation = Quaternion.Euler(new Vector3(swingAngel * 45 - 20, 0, 0));
        }
    }
}
