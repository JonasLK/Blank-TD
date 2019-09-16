using UnityEngine;

public class MoveTest : MonoBehaviour
{

    //public float hor;
    //public float ver;
    //public float movespeed;
    //public float movespeed2;
    //public float runSpeed;
    //public float runningSpeed;
    //public float walkSpeed;

    //public int jumpCount;
    //public int jumpAllowed;

    //public Vector3 v;
    //public Vector3 v2;
    //public Vector3 jumpPower;

    //Animator m_Animator;
    //public float speed1;
    //public bool sprint;

    public float panningSpeed = 20f;
    public float panningBorderSize = 10f;


    void Start()
    {
    //    //Cursor.lockState = CursorLockMode.Locked;//
    //    Cursor.visible = true;

    //    m_Animator = gameObject.GetComponent<Animator>();
    //}

    //void FixedUpdate()
    //{
    //    hor = Input.GetAxis("Horizontal");
    //    ver = Input.GetAxis("Vertical");

    //    v.x = hor;
    //    v2.z = ver;
    //    transform.Translate(v * Time.deltaTime * movespeed * runSpeed);
    //    transform.Translate(v2 * Time.deltaTime * movespeed2 * runSpeed);


    }

    void Update()
    {

        Vector3 pos1 = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panningBorderSize)
        {
            pos1.z += panningSpeed;
       
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= Screen.height - panningBorderSize)
        {
            pos1.z = +panningSpeed * Time.deltaTime;
        }
        //if (Input.GetKey("a") || Input.mousePosition.y >= Screen.width - panningBorderSize)
        //{
        //    pos1.x = +panningSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey("d") || Input.mousePosition.y <= Screen.width - panningBorderSize)
        //{
        //    pos1.x = +panningSpeed * Time.deltaTime;
        //}

        transform.position = pos1;

        //if (jumpCount < jumpAllowed)
        //{
        //    if (Input.GetButtonDown("Jump"))
        //    {
        //        GetComponent<Rigidbody>().velocity += jumpPower;
        //        jumpCount += 1;
        //    }
        //}

       // if (Input.GetButton("Sprint"))
       // {
       //     runSpeed = runningSpeed;
       // }

        //if (Input.GetButtonUp("Sprint"))
        //{
       //     runSpeed = walkSpeed;
       // }

     //   speed1 = Input.GetAxis("Vertical");
//m_Animator.SetFloat("Speed", speed1);

        //sprint = Input.GetButton("Sprint");
       // m_Animator.SetBool("Sprint", sprint);

    }

    //void OnCollisionEnter(Collision c)
    //{

    //    if (c.gameObject.tag == "Ground")
    //    {
    //        jumpCount = 0;
    //    }

    //    if (c.gameObject.tag == "Environment")
    //    {
    //        jumpCount = 0;
    //    }
    //}
}
