using UnityEngine;

public class room4_ScoreValueParsing : MonoBehaviour
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

    public static float scoreValue4 = 0;

    public void addScore4()
    {
        if (scoreValue4 != 5)
        {
            scoreValue4 += 1;
            
            Debug.Log("the official score in room 4 is " + scoreValue4);
        }
        else
        {
            return;
        }
    }
}
