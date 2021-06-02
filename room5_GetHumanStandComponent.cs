using UnityEngine;

public class room5_GetHumanStandComponent : MonoBehaviour
{
    public Rigidbody rigidbody1;
    public bool enableGrav;

    private void Update()
    {
        rigidbody1 = GetComponent<Rigidbody>();
        if (enableGrav)
            rigidbody1.useGravity = true;
        if (!enableGrav)
            rigidbody1.useGravity = false;
    }

}
