using UnityEngine;

public class room1_ScoreValueResetTest : MonoBehaviour
{
    public static float scoreValue;

    public void addScore()
    {
        scoreValue += 1;
        Debug.Log("The Score in Room 1 has been increased by 1 and it is " + scoreValue);
    }

    public void removeScore()
    {
        if (scoreValue != 0)
        {
            scoreValue -= 1;
            Debug.Log("The Score in Room 1 has been decreased by 1 and it is " + scoreValue);
        }
    }

}
