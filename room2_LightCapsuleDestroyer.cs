using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2_LightCapsuleDestroyer : MonoBehaviour
{
    public bool shouldBeDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        shouldBeDestroyed = false;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (shouldBeDestroyed)
            Destroy(gameObject);*/
    }

    public void DestroyLight()
    {
        Destroy(gameObject);
        shouldBeDestroyed = true;
    }
}
