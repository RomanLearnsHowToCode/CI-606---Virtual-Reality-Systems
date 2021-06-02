using UnityEngine;

public class mainmenu_ScoreGarden : MonoBehaviour
{
    // Turning the canvas so it's facing the player.. 
     private void LateUpdate()
     {
         transform.LookAt(Camera.main.transform);
         transform.Rotate(0, 180, 0);
     }
}
