using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform book;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.C)) {
            transform.position += new Vector3(Time.deltaTime,0,0);
        }
        if( Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.C)) {
            transform.position += new Vector3(-Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.Y) && Input.GetKey(KeyCode.C)) {
            transform.position += new Vector3(0,Time.deltaTime,0);
        }
        if( Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.C)) {
            transform.position += new Vector3(0,-Time.deltaTime,0);
        }
        transform.LookAt(book);
    }
}
