using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//music scrollbar on bottom
public class MusicSlide2 : MonoBehaviour {

    public float timeRemaining;
    private float maxTime = 79f; //86-4
    public Slider slider;
    private float timer;

    void Start() {
        slider.value = 0;
        slider.maxValue = maxTime;
        timeRemaining = 0;
        timer = 0;
    }
    void Update() {

        timer += Time.deltaTime;
        slider.value = timeRemaining;

        if (timer >= 4) {
            if (timeRemaining >= maxTime) {
                timeRemaining = maxTime;
            }
            else if (timeRemaining < maxTime) {
                timeRemaining += Time.deltaTime;
            }
        }

    }

    /* float CalculateSliderValue() {
         return (timeRemaining / maxTime);
     }*/
}
