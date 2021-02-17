using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;

    private float currentHealth = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log(currentHealth);
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("You Died");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
