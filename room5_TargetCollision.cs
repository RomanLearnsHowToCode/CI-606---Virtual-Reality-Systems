using UnityEngine;

public class room5_TargetCollision : MonoBehaviour
{
    public bool Collided = false;
    public bool RightTargetHit = false;
    public bool WrongTargetHit = false;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Target_Right")
        {
            Debug.Log(" Right Target hit!");
            RightTargetHit = true;
        }

        if (col.gameObject.name == "Target_Wrong")
        {
            Debug.Log(" Wrong Target hit!");
            WrongTargetHit = true;
        }
    }

    // new code

    public void SupposedToBeHit()
    {

        RightTargetHit = true;

    }

    public void dontHit()
    {

      WrongTargetHit = false;

    }

     

}
