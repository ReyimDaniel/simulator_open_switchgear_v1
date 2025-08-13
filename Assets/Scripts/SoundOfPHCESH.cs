using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfPHCESH : MonoBehaviour
{
    AudioSource mySource;
    public AudioClip myClip;
    private void Start()
    {
        mySource = GetComponent<AudioSource>();
    }
    public void VoidEventSound()
    {
        mySource.PlayOneShot(myClip);
    }
}
