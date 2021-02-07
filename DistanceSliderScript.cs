using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceSliderScript : MonoBehaviour
{

    public Slider distanceSlider;
    public Text distanceText;

    private void Start()
    {
        distanceSlider.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        distanceText.text = DistanceTravelled.distance.ToString()+"m";
        distanceSlider.value = DistanceTravelled.distance;
    }
}
