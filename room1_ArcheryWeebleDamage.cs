using UnityEngine;

public class room1_ArcheryWeebleDamage : MonoBehaviour
{
    [SerializeField]
    public bool Hit;
    [SerializeField]
    public bool ShouldBeHit;
    public bool Success;
    private general_GameManager gameManager;


    private void Awake()
    {
        gameManager = GameObject.FindObjectOfType<general_GameManager>();
    }

    public void Hitted()
    {
        Hit = true;
    
        if (ShouldBeHit == false & Hit == true)
        {
            Debug.Log("SHOULDNT BE HIT");
        }

        if (ShouldBeHit == true & Hit == true)
        {
            Debug.Log("SUPPOSED TO BE HIT");
            Success = true;
            gameManager.StageProgress = true;
        }
    
    }
        
}
