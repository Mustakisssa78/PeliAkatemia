using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    public float Damage = 100f;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        //create the ray's variable inside this if statement, so you avoid
        //creating it when it's not going to be used
        RaycastHit hit;
        //using ViewportPointToRay() since it does the same job for you 
        //as ScreenPointToRay(), but with less maths (not a bit 
        //performance improvement, but just doing it so you know another way)
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out hit, 100f))
        {
            //send the message the same way you were before
            hit.transform.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
        }
    }

}