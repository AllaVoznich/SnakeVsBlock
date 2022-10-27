using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip AudioClip;
    public AudioClip ChewingAudio;
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        _audio.PlayOneShot(AudioClip);
    }

    public void PlayChewingSound()
    {
        _audio.PlayOneShot(ChewingAudio);
    }
}
