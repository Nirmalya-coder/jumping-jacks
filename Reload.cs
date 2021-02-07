using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    
    public void ReloadStart()
    {
        PlayerPrefs.SetInt("coinScore", CoinCollection.score);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
    }
}
