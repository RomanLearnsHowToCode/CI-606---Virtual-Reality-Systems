using UnityEngine;

public class room1_ScoreValueParsing : MonoBehaviour
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
            Debug.Log("!ONCE_CALL was triggered and the value is " + once_call);

        } else
        {
            Debug.Log("ONCE_CALL was triggered and the value is " + once_call);
            Destroy(gameObject);
        }
    }
}