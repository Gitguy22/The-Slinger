using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 5;
    public int health { get { return currentHealth; }}
    int currentHealth;
    public GameObject projectile;




 public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        
        PlayerHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
    }

     void Start()
    {
        currentHealth = maxHealth;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "projectile")
        {
            ChangeHealth(-1);
        }
    }
}
