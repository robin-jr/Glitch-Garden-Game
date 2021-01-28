using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    Animator animator;
    Defender currentTarget;
    void Start()
    {
        animator = FindObjectOfType<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Attacker>()) { return; }
        currentTarget = other.GetComponent<Defender>();
        if (currentTarget)
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Defender>())
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void Attack(float damage)
    {
        if (currentTarget)
        {
            currentTarget.GetComponent<Health>().DealDamage(damage);
        }
    }
}
