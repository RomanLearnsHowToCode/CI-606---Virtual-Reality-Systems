using UnityEngine;

public class menu_ExitApplication : MonoBehaviour
{

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
