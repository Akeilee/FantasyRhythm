using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayMenuMusic : MonoBehaviour{

    private bool toggle;
    public AudioSource audioSource;
    public GameObject volumeIcon;
    public GameObject volumeCrossIcon;
    void Start()
    {
        volumeIcon.SetActive(true);
        volumeCrossIcon.SetActive(false);
    }

    void Update()
    {
        
    }

    public void ToggleSound() {
        toggle = !toggle;

        if (toggle) {
            volumeIcon.SetActive(false);
            volumeCrossIcon.SetActive(true);

            audioSource.volume = 0f;
        }

        else {
            if (volumeIcon.activeInHierarchy == false) {
                volumeIcon.SetActive(true);
            }
            volumeCrossIcon.SetActive(false);
            audioSource.volume = 1f;
        }

    }

}
