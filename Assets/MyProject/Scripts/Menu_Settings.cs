using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu_Settings : MonoBehaviour
{
    public static Menu_Settings MainMenu_Settings; private void Awake()
    {
        if (MainMenu_Settings == null) { MainMenu_Settings = this; }
        else if (MainMenu_Settings != this) { Destroy(gameObject); }
        LoadingSaveSound();
    }

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _audioVolume;




    public void SetVolume(float volume)
    {   //_audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
        _audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 80);
    }

    public void SetQuality(int qualityIndex)
    {   QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Sound()
    {   AudioListener.pause = !AudioListener.pause;
    }
    private void LoadingSaveSound()
    {
        if (PlayerPrefs.HasKey("_audioVolumeSave"))
        {
            _audioVolume.value = PlayerPrefs.GetFloat("_audioVolumeSave");
            SetVolume(_audioVolume.value);
        }
        else
        { SetVolume(0.5f); }
    }



    public void Save()
    {   PlayerPrefs.SetFloat("_audioVolumeSave", _audioVolume.value);
    }
  
}
