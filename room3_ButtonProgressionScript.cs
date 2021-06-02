using UnityEngine;

public class room3_ButtonProgressionScript : MonoBehaviour
{
    [SerializeField]
    public bool Press;
    [SerializeField]

    private general_GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.FindObjectOfType<general_GameManager>();
    }

    public void Pressed()
    {
        Press = true;
        
            gameManager.StageProgress = true;

    }

}
