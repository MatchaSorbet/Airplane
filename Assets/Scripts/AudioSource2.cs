using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioSource2 : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public AudioClip[] audioOnPut;
    //public AudioClip audioOnHold;

    public void Play(int index)
    {
        audioSource.clip = audioOnPut[index];
        audioSource.Play();
    }


}
