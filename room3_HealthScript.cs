using System;
using UnityEngine;

public class room3_HealthScript : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    [SerializeField]
    private int currentHealth;
    [SerializeField]
    public bool killed;
    [SerializeField]
    public GameObject Enabler;
    public event Action<float> OnHealthPctChanged = delegate { };

    public void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void ModifyHealth(int amount)
    {
        currentHealth += amount;

        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(currentHealthPct);

        if (currentHealth == 0)
        {
            Debug.Log("Object Killed");
            OnKilled();
        }
    }

    public void OnKilled()
    {
        Debug.Log("Destroy Object");
        killed = true;
        Debug.Log(killed);
        this.gameObject.SetActive(false);
        this.Enabler.SetActive(true);
    }

    public void DealDMG()
    {
        if (currentHealth != 0) { 
        ModifyHealth(-20);
        Debug.Log("DealDMG trigger " +currentHealth);
        }
    }
}
