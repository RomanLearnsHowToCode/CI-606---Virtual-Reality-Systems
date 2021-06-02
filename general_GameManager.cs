using UnityEngine;

public class general_GameManager : MonoBehaviour
{
    public bool StageProgress;
    [SerializeField]
    public GameObject Enabler;

    public void Update()
    {
        if (StageProgress)
        {
            Invoke("Deactivate", 1);
            Invoke("Activate", 2);
        }
    }

    void Deactivate()
    {
         this.gameObject.SetActive(false);
    }

    void Activate()
    {
         this.Enabler.SetActive(true);
    }
}
