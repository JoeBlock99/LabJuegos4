using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    private AudioSource audioScr;
    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audioScr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioScr.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol; 
    }
}
