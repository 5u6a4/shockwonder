using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float ShockwonderLength;
    float speed;
    private bool shokuwan_flag;
    public GameObject shokuwan;
    //nakamuraAtsushi come now !!
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (shokuwan_flag)
            {
                Vector3 nowPos = this.transform.position;
                Instantiate(shokuwan, nowPos, Quaternion.identity);
                shokuwan_flag = false;
            }
        }

    }
}
