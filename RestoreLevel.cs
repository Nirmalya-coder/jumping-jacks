using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class RestoreLevel : MonoBehaviour
{

    public GameObject DistanceSlider;
    public GameObject TapText;
    public GameObject GameOverText;
    public GameObject PauseButton;
    public static int noOfCoins = 0;
    public Text text;
    public GameObject player;
    public GameObject MainCam;

    private void Update()
    {
        text.text = "SPEND " + noOfCoins + "   TO RESUME";
    }

    public void Restore()
    {
        if (CoinCollection.score >= noOfCoins)
        {
            PlayerPrefs.SetInt("coinScore", CoinCollection.score - noOfCoins);
            Time.timeScale = 1f;
            TapText.SetActive(false);
            GameOverText.SetActive(false);
            PauseButton.SetActive(true);
            Transform player = GameObject.Find("Player").transform;
            player.position = new Vector2(player.position.x - 20f, -5.934f);
            int score = DistanceTravelled.distance + 20;
            DistanceTravelled.distance = score;
            PauseMenu.audioSource.Play();
            gameObject.SetActive(false);
            DistanceSlider.SetActive(true);
            MainCam.GetComponent<InstantiateObstacle>().StopAllCoroutines();
            player.GetComponent<checkClosestObstacle>().enabled = true;

        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Error");
            
        }
    }
      
}
