using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    bool hasAttackers;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Fire()
    {
        GameObject tempProjectile = Instantiate(projectile, gun.transform.position, transform.rotation);
        tempProjectile.transform.SetParent(transform.parent);
    }
    private void Update()
    {
        if (animator)
        {
            Figure();
        }
    }

    private void Figure()
    {
        hasAttackers = false;
        Attacker[] attackers = FindObjectsOfType<Attacker>();
        foreach (Attacker attacker in attackers)
        {
            if (Mathf.Abs(attacker.transform.position.y - transform.parent.transform.position.y) < 0.5)
            {
                hasAttackers = true;
                break;
            }
        }
        if (hasAttackers)
        {
            animator.SetBool("hasAttackers", true);
        }
        else if (!hasAttackers)
        {
            animator.SetBool("hasAttackers", false);
        }

    }
}
