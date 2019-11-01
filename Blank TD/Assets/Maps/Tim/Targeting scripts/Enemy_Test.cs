using UnityEngine;

public class Enemy_Test : MonoBehaviour
{

    public float speed = 10f;
    private float slow = 1f;


    private Transform target;
    private int wavepointIndex = 0;
    private bool slowed;
    private float slowTimer;
    private float slowTimeAmount;


    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * slow * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWavepoint();
        }

        if(slowed == true)
        {
            slowTimer += Time.deltaTime;
            if(slowTimer >= slowTimeAmount)
            {
                slowed = false;
                slow = 1f;
            }
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

    public void Slowed(float timeSlowed, float slowAmount)
    {
        slowTimeAmount = timeSlowed;
        slowed = true;
        slow = slowAmount;
    }
}