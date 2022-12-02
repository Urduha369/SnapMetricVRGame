using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource _audioObject;
    public AudioClip  _moveAudioClip, _rollAudioClip;

    public void MoveSoundEffect()
    {
        _audioObject.clip = _moveAudioClip;
        _audioObject.Play();
    }
    public void RollSoundEffect()
    {
        _audioObject.clip = _rollAudioClip;
        _audioObject.Play();
    }
}
