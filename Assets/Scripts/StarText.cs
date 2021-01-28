using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarText : MonoBehaviour
{
    [SerializeField] int currentStars = 200;
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
        if (currentStars >= count)
        {
            currentStars -= count;
            UpdateText();
        }
    }

}
