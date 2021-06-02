using UnityEngine;
using UnityEngine.UI;

public class room1_ObjectFinder : MonoBehaviour
{

    public GameObject Score;
    
    void Start()
    {

        Score = GameObject.Find("ScoreManagerRoom1");
        if (Score)
        {
            Score.GetComponent<room1_ScoreValueResetTest>();
            float ScoreX = room1_ScoreValueResetTest.scoreValue;

            Debug.Log("Score X from ObjectFinder Room1 is " + ScoreX);
            star = (int)ScoreX;
        }
    }

    //New code
    public int star;
    public int numOfStars;

    public Image[] stars;
    public Sprite emptyStar;
    public Sprite fullStar;

    void Update()
    {

        for (int i = 0; i < stars.Length; i++)
        {
            if (i < star)
            {
                stars[i].sprite = fullStar;
            }
            else
            {
                stars[i].sprite = emptyStar;
            }
            if (i < numOfStars)
            {
                stars[i].enabled = true;
            }
            else
            {
                stars[i].enabled = false;
            }
        }

    }
}
