using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Game time in Seconds")]
    [SerializeField] float levelTime = 10f;
    [SerializeField] Text timeUpText;
    Slider slider;
    bool isLevelWon;
    // Start is called before the first frame update
    void Start()
    {
        isLevelWon = false;
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLevelWon) { return; }
        slider.value = Time.timeSinceLevelLoad / levelTime;
        if (Time.timeSinceLevelLoad >= levelTime)
        {
            timeUpText.text = "You Won!!";
            timeUpText.color = new Color32(0, 255, 0, 255);
            Invoke("LevelWon", 1f);
            isLevelWon = true;
        }
    }
    private void LevelWon()
    {
        FindObjectOfType<Level>().LoadStartScreen();
    }
}
