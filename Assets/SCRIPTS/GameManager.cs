using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioClip[] soundEffects;
    private AudioSource audioSource;

    public GameObject _particle;
    public GameObject _pencil;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
    }
    public void PlayCorrectMetricSound(Vector3 objectPosition)
    {
        _particle.transform.position = objectPosition;
        _particle.SetActive(false);
        audioSource.PlayOneShot(soundEffects[0]);
        _particle.SetActive(true);
        _pencil.SetActive(false);
    }
   public void PlayIncorrectMetricSound()
    {
        audioSource.PlayOneShot(soundEffects[1]);
        _particle.SetActive(false);
    }

}
