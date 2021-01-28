using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    StarText starText;
    private void Start()
    {
        starText = FindObjectOfType<StarText>();
    }
    private void AddStars(int count)
    {
        starText.AddStars(count);
    }
}
