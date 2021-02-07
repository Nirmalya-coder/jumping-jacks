using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ResumeMenu : MonoBehaviour {

    public void Resume()
	{
		Time.timeScale = 1f;
        PauseMenu.audioSource.Play();

    }
}