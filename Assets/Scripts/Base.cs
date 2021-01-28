using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    HealthText healthText;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        healthText = FindObjectOfType<HealthText>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Attacker>())
        {
            healthText.SpendStars(100);
            spriteRenderer.color = new Color32(154, 19, 19, 152);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Attacker>())
        {
            spriteRenderer.color = new Color32(0, 0, 0, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
