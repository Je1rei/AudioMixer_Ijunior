using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderSoundHandler : MonoBehaviour
{
    private const string _masterVolumeParameter = "MasterVolume";
    private const string _musicVolumeParameter = "MusicVolume";
    private const string _uiVolumeParameter = "UIVolume";

    [SerializeField] private AudioMixerGroup _mixer;

    private Slider _slider;

    private float _value;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = 0.0001f;
        _value = _slider.value;
    }

    public void SetMasterVolume()
    {
        _value = _slider.value;
        _mixer.audioMixer.SetFloat(_masterVolumeParameter, Mathf.Log10(_value) * 20);
    }    

    public void SetMusicVolume()
    {
        _value = _slider.value;
        _mixer.audioMixer.SetFloat(_musicVolumeParameter, Mathf.Log10(_value) * 20);
    }  
    
    public void SetUIVolume()
    {
        _value = _slider.value;
        _mixer.audioMixer.SetFloat(_uiVolumeParameter, Mathf.Log10(_value) * 20);
    }

}


