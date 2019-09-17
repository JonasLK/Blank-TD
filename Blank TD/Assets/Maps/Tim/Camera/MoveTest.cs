using UnityEngine;

public class MoveTest : MonoBehaviour
{


    public float panningSpeed = 20f;
    public float panningBorderSize = 10f;


    void Start()
    {

    }

    void Update()
    {

        Vector3 pos1 = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panningBorderSize)
        {
            pos1.x += +panningSpeed * Time.deltaTime;
       
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panningBorderSize)
        {
            pos1.x -= +panningSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panningBorderSize)
        {
            pos1.z -= +panningSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panningBorderSize)
        {
            pos1.z += +panningSpeed * Time.deltaTime;
        }

        transform.position = pos1;
        
}
