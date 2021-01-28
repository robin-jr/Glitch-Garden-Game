using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
        audioSource.Play();
        DontDestroyOnLoad(this);
    }

    public void SetVolume(float volume)
    {
        PlayerPrefsController.SetMasterVolume(volume);
        audioSource.volume = volume;
    }

}
