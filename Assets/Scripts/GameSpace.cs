using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpace : MonoBehaviour
{
    Defender defender;
    StarText starText;

    private void Start()
    {
        starText = FindObjectOfType<StarText>();
    }
    public void SetDefender(Defender defender)
    {
        this.defender = defender;
    }

    private void OnMouseDown()
    {
        if (!defender || !starText) { return; }
        int cost = defender.GetCost();
        if (starText.GetStarsCount() >= cost)
        {
            SpawnDefender(GetWorldPos());
            starText.SpendStars(cost);
        }
    }
    private Vector2 GetWorldPos()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return new Vector2(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
    }

    private void SpawnDefender(Vector2 position)
    {
        Instantiate(defender, position, Quaternion.identity);
    }
}
