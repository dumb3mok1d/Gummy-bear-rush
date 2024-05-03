using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healh : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float currentHealth;

    // Start is called before the first frame update
    private void Awake ()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
   public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            //player hurt
        }
        else
        {
            //player dead 
        }
    }
}
