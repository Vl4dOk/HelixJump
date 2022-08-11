using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu_Settings : MonoBehaviour
{
    [SerializeField] private GameObject _menu_Settings;

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _audioVolume;


    private void Awake()
    {
        if (_menu_Settings == null) { _menu_Settings = gameObject; }

        LoadingSaveSound();
        Deactivate_Menu_Settings();
    }

    public void Activate_Menu_Settings() { _menu_Settings.SetActive(true);}
    public void Deactivate_Menu_Settings() { _menu_Settings.SetActive(false);}


    public void SetVolume(float volume)
    {   //_audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
        _audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 80);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    private void LoadingSaveSound()
    {
        float volume = PlayerPrefs.GetFloat("_audioVolumeSave", 0.5f);
        _audioVolume.value = volume;
        SetVolume(volume);
    }



    public void Save()
    {
        PlayerPrefs.SetFloat("_audioVolumeSave", _audioVolume.value);
    }

}