using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // This script was found at https://answers.unity.com/questions/548794/how-to-move-a-camera-only-using-the-arrow-keys.html
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0,-speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.position += new Vector3(0,speed * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0,0,-speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0,speed * Time.deltaTime);
        }
    }
}
