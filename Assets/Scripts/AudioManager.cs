using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioSource intro;
    public AudioClip introClip;
    public AudioClip clickClip;
    public AudioClip HoldUp;
    
    void Start()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
        {
            source.Play();
        }
        if (scene == 0)
        {
            intro.PlayOneShot(introClip);
        }

    }
    public void playClickSound()
    {
        source.PlayOneShot(clickClip);
    }
    public void holdUp()
    {
        source.PlayOneShot(HoldUp);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
