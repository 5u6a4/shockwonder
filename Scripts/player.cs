using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player : MonoBehaviour
{
    float speed;
    private bool shokuwan_flag;
    private bool stay_flag;
    public GameObject sw;
    private Rigidbody rb;

    private Vector3 distination;

    //shokuwan classはshokuwan.csに存在 
    shokuwan shokuwanScript;


    [SerializeField] private Vector3 localGravity;

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
                Instantiate(sw, nowPos, Quaternion.identity);
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

        shokuwanScript = sw.GetComponent<shokuwan>();
        if (shokuwan.instance != null)//　<-　天才「bool変数にnull代入回避」
        {
            stay_flag = shokuwan.instance.isAttatched;
        }

        Debug.Log(stay_flag);
    }

    void Move()
    {
        if (stay_flag)
        {
            distination = sw.gameObject.transform.position;
            rb.AddForce(distination.x - rb.position.x, distination.y - rb.position.y, 0);
        }
        else
        {
            SetLocalGravity();
        }

    }
}
