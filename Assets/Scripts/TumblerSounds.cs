using UnityEngine;
using UnityEngine.Audio;

public class TumblerSounds : MonoBehaviour
{
    private const string _masterVolume = "MasterVolume";

    [SerializeField] private Button _button;
    [SerializeField] private AudioMixerGroup _mixer;

    private void OnEnable()
    {
        _button.Clicked += Toggle;
    }

    private void OnDisable()
    {
        _button.Clicked -= Toggle;
    }

    private void Toggle()
    {
        float minValue = -80f;
        _mixer.audioMixer.GetFloat(_masterVolume, out float currentVolume);

        if (currentVolume < 0)
            _mixer.audioMixer.SetFloat(_masterVolume, 0);
        else
            _mixer.audioMixer.SetFloat(_masterVolume, minValue);
    }
}
