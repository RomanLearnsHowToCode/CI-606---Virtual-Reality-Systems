
using UnityEngine;

public class room5_ScoreValueParsing : MonoBehaviour
{

    [SerializeField]
    public GameObject ScoreManager;

    static public bool once_call;

    private void Awake()
    {
        if (!once_call)
        {
            DontDestroyOnLoad(this);
            once_call = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static float scoreValue5;
    
    public void addScore5()
    {
        scoreValue5 += 1;
        Debug.Log("The Score from Room 5 is " + scoreValue5);
    }

    public void removeScore5()
    {
        if (scoreValue5 > 0)
        {
            scoreValue5 -= 1;
            Debug.Log("Score in room 5 was decreased " + scoreValue5);
        } else
        {
            Debug.Log("Score in room 5 couldnt been decreased " + scoreValue5);
            return;
        }
    }

}






