using UnityEngine;
using UnityEngine.UI;

public class room4_ObjectFinder : MonoBehaviour
{
    public GameObject Score;

    void Start()
    {
        //UnityEngine.Object.FindObjectsOfType(ScoreValueParsing);
        Score = GameObject.Find("ScoreManagerRoom4");
        if (Score)
        {
            Score.GetComponent<room4_ScoreValueParsing>();
            float ScoreX = room4_ScoreValueParsing.scoreValue4;
            Debug.Log("Score X from ObjectFinder4 is " + ScoreX);

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
