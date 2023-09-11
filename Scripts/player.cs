using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float ShockwonderLength;
    float speed;

    public GameObject shokuwan;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 nowPos = this.transform.position;
            Instantiate(shokuwan, nowPos,Quaternion.identity);
        }
    }
}
