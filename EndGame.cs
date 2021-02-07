using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class EndGame : MonoBehaviour {

    public GameObject GameOverText;
	public GameObject TapText;
	public GameObject PauseButton;
    public GameObject ScoreReduce;
    public GameObject DistanceSlider;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.tag == "Obstacle") 
		{
			GameOverText.SetActive (true);
			TapText.SetActive (true);
            PauseButton.SetActive(false);
			FindObjectOfType<AudioManager>().Play ("GameOver");
			Time.timeScale = 0f;
            PauseMenu.audioSource.Pause();
            ScoreReduce.SetActive(true);
            DistanceSlider.SetActive(false);

        }
	}
    void Update()
    {
        int max = PlayerPrefs.GetInt("maxScore");
        if (DistanceTravelled.distance > max)
            PlayerPrefs.SetInt("maxScore", DistanceTravelled.distance);
    }
   
}



