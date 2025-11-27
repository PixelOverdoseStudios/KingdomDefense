using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float moveSpeed = 2f;

    [Header("Misc")]
    [SerializeField] private int currentPoint = 0;
    [SerializeField] private Transform[] waypoints;

    private void Update()
    {
        MovePointToPoint();
    }

    private void MovePointToPoint()
    {
        if(Vector2.Distance(transform.position, waypoints[currentPoint].position) < 0.01f)
        {
            currentPoint++;

            if(currentPoint > waypoints.Length - 1)
            {
                currentPoint = 0;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].position, moveSpeed * Time.deltaTime);
        }
    }
}
