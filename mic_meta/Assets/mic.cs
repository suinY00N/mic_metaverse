using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mic : MonoBehaviour
{
    private AudioSource aud;
    //private AudioClip mic;
    private int lastSample = 0;
    private float[] samples = null;
  
    bool IsAvaliable;


    void Start()
    { 
        aud = GetComponent<AudioSource>();
    }
    public void PlaySnd()
    {
        aud.Play();
    }
    public void RecSnd()
    {
        aud.clip = Microphone.Start(Microphone.devices[0].ToString(), false, 100,44100);
    }
    public void StopSnd()
    {
        aud.Stop();
    }

    void Update()
    {
        
    }
}    