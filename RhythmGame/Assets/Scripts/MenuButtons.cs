using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Start Menu
public class MenuButtons : MonoBehaviour{

    public GameObject instructions;
    public AudioSource audioSource;
    public AudioClip openMenu;

    public bool startPlaying;
    private AudioSource musicSource { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        instructions.SetActive(false);
      //  musicSource.playOnAwake = true;
        
    }

  
    void Update(){
        if (!startPlaying) {
            audioSource.Play();
            startPlaying = true;
        }

    }

    public void InstructionsOpen() {
        instructions.SetActive(true);
       
    }

    public void CloseInstructions() {
        instructions.SetActive(false);  
    }

    public void Song1() {
        //Debug.Log("song 1");
        SceneManager.LoadScene("SecondSong");
    }

    public void Song2() {
        //Debug.Log("song 2");
        SceneManager.LoadScene("MainGame");
    }

    public void ExitGame() {
        //  Debug.Log("Quitting game");
        Application.Quit();
    }
}
