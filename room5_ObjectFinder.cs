using UnityEngine;
using UnityEngine.UI;

public class room5_ObjectFinder : MonoBehaviour
{
    public GameObject Score;

    void Start()
    {
        //UnityEngine.Object.FindObjectsOfType(ScoreValueParsing);
        Score = GameObject.Find("ScoreManagerRoom5");
        if (Score)
        {
            Score.GetComponent<room5_ScoreValueParsing>();
            float ScoreX = room5_ScoreValueParsing.scoreValue5;
            Debug.Log("Score X from ObjectFinder5 is " + ScoreX);

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
