using UnityEngine;

public class general_SoundEffectManager : MonoBehaviour
{

    public AudioSource myFx;
    //General Sounds
    public AudioClip ButtonClickRight;
    public AudioClip ButtonClickWrong;
    //Room1
    public AudioClip DamageSound;
    public AudioClip DamageSound2;
    //Room2
    public AudioClip BallonSound1;
    public AudioClip BallonSound2;
    public AudioClip TargetSound;
    //Room3
    public AudioClip FireBreathSound;
    public AudioClip SwordAttackSound;
    public AudioClip DragonDeath;
    public AudioClip WarriorDeath;
    public AudioClip DragonTookDamage;
    public AudioClip WarriorTookDamage;
    //Room4
    //Room5


    //SOUND FUNCTIONS
    public void RightButtonClick()
    {
        myFx.PlayOneShot(ButtonClickRight);
    }

    public void WrongButtonClick()
    {
        myFx.PlayOneShot(ButtonClickWrong);
    }


    public void Room1DamageSound()
    {
        myFx.PlayOneShot(DamageSound);
    }


    public void DragonAttack()
    {
        myFx.PlayOneShot(FireBreathSound);
    }

    public void WarriorAttack()
    {
        myFx.PlayOneShot(SwordAttackSound);
    }

    public void DragonHasDied()
    {
        myFx.PlayOneShot(DragonDeath);
    }

    public void WarriorHasDied()
    {
        myFx.PlayOneShot(WarriorDeath);
    }

    public void DragonDamage()
    {
        myFx.PlayOneShot(DragonTookDamage);
    }

    public void WarriorDamage()
    {
        myFx.PlayOneShot(WarriorTookDamage);
    }

}
