using UnityEngine;
using TMPro;

public class ResultManager: MonoBehaviour
{
    public TMP_Text resultText;

    public TMP_Text resetText;

    void Start()
    {
        
    }

    public void CheckResult(int score, int remainingBalls)
    {
        if (score >= 7)
        {
            SetResultText("Win");
        }else
        {
            if (remainingBalls == 0)
            {
                SetResultText("Lose");
            }
        }
    }

    public void ClearResultText()
    {
        resultText.text = "";
        resetText.text = "";
    }

    void SetResultText(string result)
    {
        resultText.text = "You " + result;
        resetText.text = "Tap Button to Reset Game";
    }
}