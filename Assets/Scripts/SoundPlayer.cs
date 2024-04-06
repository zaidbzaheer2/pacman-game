using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    private AudioSource activeSound, deadSound;
    // Start is called before the first frame update
    void Start()
    {
        deadSound = transform.GetChild(0).GetComponent<AudioSource>();
        activeSound = transform.GetChild(1).GetComponent<AudioSource>();
    }
    public void playAliveSound()
    {
        if(activeSound!=null && !activeSound.isPlaying)
        activeSound.Play();
    }
    public void StopSounds()
    {

    }
    public void playDeadSound()
    {
        activeSound.Stop();
        if(deadSound !=null && !deadSound.isPlaying)
        deadSound.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
