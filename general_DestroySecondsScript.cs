using UnityEngine;

public class general_DestroySecondsScript : MonoBehaviour
{
    public float seconds;

    public void Start()
    {
        DestroyAfter();
    }

    public void DestroyAfter()
    {
        Destroy(gameObject, seconds);
    }
}
