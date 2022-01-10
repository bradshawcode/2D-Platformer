using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntractableBody : MonoBehaviour
{
    [SerializeField] private float health = 0;
    private float MaxHealth = 999;
    public float Health { get { return health; } set { health = value; } } // playerHealth = value is what the code on the other end wants.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Damage>().DamageType == this.gameObject.GetComponent<Damage>().AcceptType)
        {
            //Mathf.Clamp(health, 0, MaxHealth);

            health -= 10;

            if (health <= 0)
                Destroy(this.gameObject);
        }
    }
}
