using UnityEngine;
using Valve.VR.InteractionSystem;

public class room2_ItemInteraction : MonoBehaviour
{
    public Interactable interactable;
    private room2_GameManager gameManager;

    public bool collided1;
    public bool collided2;

    // Start is called before the first frame update
    void Start()
    {
       
        interactable = GetComponent<Interactable>();
        gameManager = GameObject.FindObjectOfType<room2_GameManager>();
        

        if (gameManager)
        {
            Debug.Log("Game Manager was found " + gameManager);
        }

    }

    // Update is called once per frame
    void Update()
    {  
        if (interactable.attachedToHand && collided1 == false)
        {
            Debug.Log("ATTACHED TO HAND!!");
            gameManager.Enable = true;
            gameManager.Disable = true;
            Debug.Log("Collided1 is " + collided1);
            collided1 = true;
        }
    }
}
