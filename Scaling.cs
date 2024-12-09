using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    public float increasedScale;
    public float maxScale = 1.5f;
    public float startZ;
    public float scalingSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        startZ = transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {

        if (increasedScale < maxScale && Input.GetAxisRaw("Horizontal") > 0 && Middel.currentAngel > 180)
        {
            increasedScale += Time.deltaTime * scalingSpeed;
            transform.localScale += new Vector3(0, 0, Time.deltaTime * scalingSpeed);
        }
        if (increasedScale > startZ && Input.GetAxisRaw("Horizontal") < 0) {
            increasedScale -= Time.deltaTime * scalingSpeed;
            transform.localScale -= new Vector3(0, 0, Time.deltaTime * scalingSpeed);
        }
    }
}
