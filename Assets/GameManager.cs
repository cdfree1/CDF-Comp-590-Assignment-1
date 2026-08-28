using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager: MonoBehaviour
{
    public int remainingBalls = 10;

    public BallShooter ballShooter;

    public ScoreManager scoreManager;

    public ResultManager resultManager;

    bool waitingForFinalResult;
    void Update()
    {
        if (waitingForFinalResult)
        {
            return;
        }
        if (Touchscreen.current != null &&
            Touchscreen.current.press.wasPressedThisFrame)
        {
            if (remainingBalls > 0)
            {
                remainingBalls -= 1;
                ballShooter.Shoot();

                if (remainingBalls == 0)
                {
                    waitingForFinalResult = true;
                    Invoke(nameof(CheckFinalResult), 1.25f);
                }
            }else
            {
                ResetGame();
            }
        }
        
    }

    void CheckFinalResult()
    {
        resultManager.CheckResult(scoreManager.score, remainingBalls);
        waitingForFinalResult = false;
    }

    void ResetGame()
    {
        CancelInvoke(nameof(CheckFinalResult));

        waitingForFinalResult = false;
        remainingBalls = 10;
        scoreManager.ResetScore();
        resultManager.ClearResultText();
    }
}