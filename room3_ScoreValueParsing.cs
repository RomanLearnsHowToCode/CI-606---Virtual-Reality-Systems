using UnityEngine;

public class room3_ScoreValueParsing : MonoBehaviour
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

    public static float scoreValue3;

    public void addScore3()
    {

        scoreValue3 += 1;
        Debug.Log("the official score was increased and is " + scoreValue3);

    }

    public void removeScore3()
    {
        if (scoreValue3 > 0)
        {
        scoreValue3 -= 1;
        Debug.Log("the official score was decreased and is " + scoreValue3);
        }
    }
}
