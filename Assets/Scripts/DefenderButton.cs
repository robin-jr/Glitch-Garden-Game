using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defender;
    SpriteRenderer spriteRenderer;
    GameSpace gameSpace;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameSpace = FindObjectOfType<GameSpace>();
    }
    private void OnMouseDown()
    {
        DefenderButton[] buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(100, 100, 200, 255);
        }
        spriteRenderer.color = Color.white;
        gameSpace.SetDefender(defender);
    }
}
