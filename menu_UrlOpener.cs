using UnityEngine;

public class menu_UrlOpener : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
        Debug.Log("URL opened");
    }
}
