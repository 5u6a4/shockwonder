using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shokuwan : MonoBehaviour
{
    public float length;
    private Rigidbody rb;
    public float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f, 2.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

        //rb.velocity = new Vector3(5.0f, 2.0f, 0.0f);

        
    }
}