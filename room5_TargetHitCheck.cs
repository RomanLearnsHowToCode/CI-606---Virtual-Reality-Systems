using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class room5_TargetHitCheck : MonoBehaviour
{
    public UnityEvent TargetHit;
    public bool SupposedToBeHit;
    public bool SupposedNotToBeHit;
    private general_GameManager gameManager;
    private room5_ScoreValueParsing scoreManager;
    private general_SoundEffectManager soundEffects;
    private room5_GetHumanStandComponent humanStand;

    private void Awake()
    {
        gameManager = GameObject.FindObjectOfType<general_GameManager>();
        scoreManager = GameObject.FindObjectOfType<room5_ScoreValueParsing>();
        soundEffects = GameObject.FindObjectOfType<general_SoundEffectManager>();
        humanStand = GameObject.FindObjectOfType<room5_GetHumanStandComponent>();

        if(gameManager)
        {
            Debug.Log("GameManager Found");
        } else
        {
            Debug.Log("GameManager NOT found");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Hitted();
    }

    public void Hitted()
    {
        if (SupposedToBeHit)
        {
            Debug.Log("Right target has been hitted");
            scoreManager.addScore5();
            gameManager.StageProgress = true;
            soundEffects.RightButtonClick();
            soundEffects.Room1DamageSound();

        }
        else if (SupposedNotToBeHit)
        {
            scoreManager.removeScore5();
            gameManager.StageProgress = true;
            Debug.Log("Wrong Target has been hitted");
            soundEffects.Room1DamageSound();
            soundEffects.WrongButtonClick();
            soundEffects.WarriorHasDied();
            humanStand.enableGrav = true;
        }
    }
}