using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderControlledFireScript : MonoBehaviour
{
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
    public void rotateNozzel(float newRotate)
    {
        speed = newRotate;
    }
}
