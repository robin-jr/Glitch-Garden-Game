using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    [SerializeField] int currentStars = 200;
    [SerializeField] Text gameOverText;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateText();
    }

    public int GetStarsCount()
    {
        return currentStars;
    }

    private void UpdateText()
    {
        starText.text = currentStars.ToString();
    }

    public void AddStars(int count)
    {
        currentStars += count;
        UpdateText();
    }
    public void SpendStars(int count)
    {
        if (currentStars <= 0)
        {
            return;
        }
        currentStars -= count;
        UpdateText();

        if (currentStars <= 0)
        {
            if (gameOverText)
            {
                gameOverText.color = new Color32(255, 0, 0, 255);
            }
            Invoke("GameOver", 2f);
        }
    }
    private void GameOver()
    {
        FindObjectOfType<Level>().LoadGameOverScreen();

    }
}
