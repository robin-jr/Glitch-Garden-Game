using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    int points;
    private void Start()
    {
        points = Mathf.RoundToInt(health);
    }
    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            if (GetComponent<Attacker>())
            {
                StarText starText = FindObjectOfType<StarText>();
                starText.AddStars(points);
                //Adding star count equivalent to the health of the attacker being destroyed
            }
            if (deathVFX)
            {
                GameObject vfx = Instantiate(deathVFX, transform.position, transform.rotation);
                Destroy(vfx, 1f);
            }
            Destroy(gameObject);
        }
    }
}