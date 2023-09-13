using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shokuwan : MonoBehaviour
{
    public static shokuwan instance;
    private Rigidbody rb;
    public float velocity = 100f;
    private Vector3 nowPos;
    public bool isAttatched;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(velocity, 0.5f * velocity, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (isAttatched)
        {
            rb.transform.position = nowPos;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Object.Destroy(this.gameObject);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        rb.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        nowPos = this.transform.position;
        isAttatched = true;
        Debug.Log("hit");
    }

}
