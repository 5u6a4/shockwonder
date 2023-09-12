using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shokuwan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector2(1.0f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
