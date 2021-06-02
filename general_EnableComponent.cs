using UnityEngine;

public class general_EnableComponent : MonoBehaviour
{

    public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        Object = GetComponent<GameObject>();
    }

}
