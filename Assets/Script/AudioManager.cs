using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    public static AudioManager Instance { get { return instance; } }

    public AudioMixer masterMixer;

    public Slider musicSlider, masterSlider;

    private void Awake()
    {
        if (instance == null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMusicVolume());
        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());

        if (masterSlider != null)
            PreferencesManager.GetMasterVolume();
        if (masterSlider != null)
            PreferencesManager.GetMusicVolume();
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }
}
