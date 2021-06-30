using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public float health = 100f;

    public void ApplyDamage(float DamageAmount)
    {
        //No need to raycast again in this method, since you 
        //already know this has been hit / damaged by whatever!
        //Also, by taking the raycast out of this method, you 
        //can use this method to apply damage from any source
        //to your enemy... eg, environmental hazards you 
        //script, explosions you script, etc.

        health -= DamageAmount;

        if (health < 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}


