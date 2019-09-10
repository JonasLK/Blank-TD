using UnityEngine;

public class Enemy_Test : MonoBehaviour
{

    public float speed = 10f;


    private Transform target;
    private int wavepointIndex = 0;


    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWavepoint();
        }
    }

    void GetNextWavepoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

}
