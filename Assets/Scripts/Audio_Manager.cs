using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public AudioClip fireSound;
    public AudioClip playerDiesSound;
    public AudioClip backgroundMusic;
    public AudioClip invaderDiesSound;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playFireSound()
    {
        GetComponent<AudioSource>().PlayOneShot(fireSound);
    }

    public void playExplosion()
    {
        GetComponent<AudioSource>().PlayOneShot(playerDiesSound);
    }

    public void playInvaderDied()
    {
        GetComponent<AudioSource>().PlayOneShot(invaderDiesSound);
    }
}
