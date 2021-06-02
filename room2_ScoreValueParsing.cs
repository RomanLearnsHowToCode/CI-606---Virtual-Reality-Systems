using UnityEngine;

public class room2_ScoreValueParsing : MonoBehaviour
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

    public static float scoreValue2;

    public void addScore()
    {

        scoreValue2 += 1;
        Debug.Log("Right button: the official score is " + scoreValue2);

    }

    public void removeScore()
    {
        if (scoreValue2 > 0)
        scoreValue2 -= 1;
        Debug.Log("Wrong button: the official score is " + scoreValue2);
    }
}
