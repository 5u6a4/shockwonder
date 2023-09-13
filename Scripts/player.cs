using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player : MonoBehaviour
{
    float ShockwonderLength;
    float speed;
    private bool shokuwan_flag;
    private bool stay_flag;
    public GameObject shokuwan;
    private Rigidbody rb;

    private Vector3 distination;


    [SerializeField] private Vector3 localGravity;
    shokuwan shokuwanScript;
    //nakamuraAtsushi come now !!

    // Start is called before the first frame update
    void Start()
    {
        shokuwan_flag = true;
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {

        Check();
        thrrow();
        Move();
    }
    void thrrow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (shokuwan_flag)
            {
                Vector3 nowPos = this.transform.position;
                Instantiate(shokuwan, nowPos, Quaternion.identity);
                shokuwan_flag = false;
                Debug.Log("shot");
            }
            else
            {
                shokuwan_flag = true;
            }
        }
    }
    void SetLocalGravity()
    {
        rb.AddForce(localGravity, ForceMode.Acceleration);
    }
    void Check()
    {
        shokuwanScript = shokuwan.GetComponent<shokuwan>();
        stay_flag = shokuwanScript.isAttatched;
        Debug.Log(stay_flag);
    }

    void Move()
    {
        if (stay_flag)
        {
            distination = shokuwan.gameObject.transform.position;
            rb.AddForce(distination.x - rb.position.x, distination.y - rb.position.y, 0);
        }
        else
        {
            SetLocalGravity();
        }

    }
}


