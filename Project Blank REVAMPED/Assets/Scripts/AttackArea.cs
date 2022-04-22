using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    [SerializeField]
    private int damage = 10;



    void OnTriggerEnter2D(Collider2D collider)
    {
     // .Log("Collider Reached, seaching for EmemyHealth...(1/3)");
        if(collider.GetComponent<EnemyHealth>() != null)
        {
            EnemyHealth health = collider.GetComponent<EnemyHealth>();
            // Debug.Log("EmemyHealth reached, running damage...(2/3)");
            health.Damage(damage);
            // Debug.Log("EmemyHealth reached, damage done, code file(AttackArea.cs) ran(3/3)");
        }
       
    }
}
