using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour {

    public static AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioSource").GetComponent<AudioSource>();
    }

    public void Pause()
	{
		Time.timeScale = 0f;
        audioSource.Pause();
    }
}
