using UnityEngine;

public class HoopMover : MonoBehaviour
{
    public float moveDistance = 3f;
    public float speed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset =
            Mathf.PingPong(Time.time * speed, moveDistance * 2)
            - moveDistance;

        transform.position =
            startPosition + Vector3.right * offset;
    }
}