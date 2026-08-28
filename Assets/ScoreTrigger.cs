using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            scoreManager.AddPoint();
        }
    }
}