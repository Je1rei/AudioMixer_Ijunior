using System;
using UnityEngine;

public class SoundButton: Button
{
    [SerializeField] private AudioClip _sound;

    public event Action<AudioClip> SoundClicked;

    public override void Click()
    {
        base.Click();

        SoundClicked?.Invoke(_sound);
    }
}
