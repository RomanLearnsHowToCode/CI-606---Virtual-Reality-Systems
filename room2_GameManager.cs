using UnityEngine;
using Valve.VR.InteractionSystem;

public class room2_GameManager : MonoBehaviour
{
    public bool Disable;
    public bool Enable;

    public bool Collided;

    public GameObject Enabler;

   
    public Interactable interactable;

    private void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    public void Update()
    {

        // This script is only to react with a LightCapsule
        if (interactable.attachedToHand && Collided == false)
        {
            Enabler.SetActive(true);
            Collided = true;
        }

    }

    //This code is for Enabler to be activated
    public void Activate()
    {
        this.Enabler.SetActive(true);
    }

}
