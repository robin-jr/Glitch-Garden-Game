using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.4f);
        print(PlayerPrefsController.GetMasterVolume());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetTestVolume(System.Single volume)
    {
        print(volume);
    }
}
