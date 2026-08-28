using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public BallPrefab ballPrefab;

    public void Shoot()
    {
        BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);

        ball.transform.position = transform.position;

        ball.GetComponent<Rigidbody>().AddForce(
            Camera.main.transform.forward * Random.Range(750f, 1000f)
        );
    }
}