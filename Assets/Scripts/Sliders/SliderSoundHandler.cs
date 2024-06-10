using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderSoundHandler : MonoBehaviour
{
    private const float _dBModifyer = 20f;

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private string _volumeParameterName;

    private Slider _slider;
    private float _value;
    private float _minValueSlider = 0.0001f;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = _minValueSlider;
        _value = _slider.value;
    }

    public void SetVolume()
    {
        _value = _slider.value;
        _mixer.SetFloat(_volumeParameterName, Mathf.Log10(_value) * _dBModifyer);
    }
}


