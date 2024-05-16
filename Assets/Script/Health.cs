using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    // Start is called before the first frame update
    private void Awake ()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
            //iframes???
           
        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("died");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }
            
        }

        

    }
              
   public void Respawn()
    {
        dead = false;
        AddHealth(startingHealth);
        anim.ResetTrigger("died");
        anim.Play("Idle");

        
    }

    private void AddHealth(float startingHealth)
    {
        throw new NotImplementedException();
    }
}
