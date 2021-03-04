using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EqualsMenu : MonoBehaviour
{
    public GameObject instructionWindow;
    public GameObject equalMenu;
    private bool menuOpened = false;
    void Start()
    {
        //instructionWindow.SetActive(true);
        equalMenu.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Equals)) {
            if (!menuOpened) {
                OpenMenu();
            }
            else {
                CloseMenu();
            }
        }
    }

    private void OpenMenu() {
        equalMenu.SetActive(true);
        instructionWindow.SetActive(false);
        menuOpened = true;
    }

    private void CloseMenu() {
        instructionWindow.SetActive(true);
        equalMenu.SetActive(false);
        menuOpened = false;
    }
}
