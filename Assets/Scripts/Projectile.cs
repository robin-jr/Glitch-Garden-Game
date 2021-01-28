using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float damage = 50f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Defender>()) { return; }
        Health health = other.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
