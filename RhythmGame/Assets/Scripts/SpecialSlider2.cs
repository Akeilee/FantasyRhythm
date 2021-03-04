using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialSlider2 : MonoBehaviour {

    public GameManager2 GM;
    private float maxValue = 18;
    public Slider slider;
    public GameObject special;
    public GameObject success;
    public GameObject fail;
    void Start() {
        slider.value = 0;
        slider.maxValue = maxValue;
        special.SetActive(false);
    }

    void Update() {
        slider.maxValue = maxValue;

        if (GM.timecount >= 47) {
            special.SetActive(true);
            slider.value = GM.specialCounter;
        }

        if (GM.timecount >= 61) {
            special.SetActive(false);
        }

        if (GM.timecount >= 61 && GM.specialCounter >= 10) {
            success.SetActive(true);
        }
        if (GM.timecount >= 61 && GM.specialCounter < 10) {
            fail.SetActive(true);
        }

        if (GM.timecount >= 63) {
            success.SetActive(false);
            fail.SetActive(false);
        }
    }
}
