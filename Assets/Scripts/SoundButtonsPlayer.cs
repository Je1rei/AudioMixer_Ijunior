using UnityEngine;

public class SoundButtonsPlayer : MonoBehaviour
{
    [SerializeField] private SoundButton[] _buttons;
    [SerializeField] private AudioSource _tapSource;

    private void OnEnable()
    {
        foreach (var button in _buttons)
            button.SoundClicked += Play;
    }

    private void OnDisable()
    {
        foreach (var button in _buttons)
            button.SoundClicked -= Play;
    }

    private void Play(AudioClip clip)
    {
        _tapSource.clip = clip;
        _tapSource.Play();
    }
}
