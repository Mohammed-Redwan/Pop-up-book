using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnOpen : MonoBehaviour
{
    public static float inBookAngel;
    public Vector3 rotateVector = Vector3.right;
    public Space space = Space.Self;
    public static float numOfOpject = 4 + 2;
    public float requireBookAngelToRotate = 90;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxisRaw("Horizontal") > 0 && Middel.currentAngel > requireBookAngelToRotate && inBookAngel < 90 * numOfOpject) {
            inBookAngel += Time.deltaTime * Middel.rotateSpeed;
            transform.Rotate(rotateVector, Time.deltaTime * Middel.rotateSpeed);
        }

        if (Input.GetAxisRaw("Horizontal") < 0 && Middel.currentAngel > requireBookAngelToRotate && inBookAngel > 0) {
            inBookAngel -= Time.deltaTime * Middel.rotateSpeed;
            transform.Rotate(rotateVector, -Time.deltaTime * Middel.rotateSpeed, Space.Self);
            
        }
        
    }
}
