using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//pressing notes to make them disappear
public class NoteObject2 : MonoBehaviour {

    public static object instance;
    public bool canBePressed;
    public KeyCode keyToPress;
    private float buttonXPos = -2.65f;
    public GameObject coolEffect, greatEffect, perfectEffect, missEffect;
    Vector3 pos = new Vector3(0, 0, 0);
    public static bool cheat = false;

    void Start() {

    }

    void Update() {

        if (Time.timeScale != 0f && cheat == true) {
            if (canBePressed) {
                gameObject.SetActive(false);
                GameManager2.instance.PerfectHit();
                Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
            }
        }

        if (Input.GetKeyDown(keyToPress) && Time.timeScale != 0f && cheat == false) {
            if (canBePressed) {
                gameObject.SetActive(false); //deactivate object

                if (transform.position.x > buttonXPos + 0.255 || transform.position.x < buttonXPos - 0.255) {
                    //Debug.Log("Cool" + transform.position);
                    GameManager2.instance.CoolHit();
                    pos = new Vector3(-3.6f, transform.position.y, transform.position.z);
                    Instantiate(coolEffect, transform.position, coolEffect.transform.rotation);
                }
                else if (transform.position.x > buttonXPos + 0.121 || transform.position.x < buttonXPos - 0.121) {
                    //Debug.Log("Great" + transform.position);
                    GameManager2.instance.GreatHit();
                    pos = new Vector3(-3.6f, transform.position.y, transform.position.z);
                    Instantiate(greatEffect, transform.position, greatEffect.transform.rotation);
                }
                else {
                    //Debug.Log("Perfect" + transform.position);
                    GameManager2.instance.PerfectHit();
                    pos = new Vector3(-3.6f, transform.position.y, transform.position.z);
                    Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                }

            }


        }

        //going off screen disappears
        if (transform.position.x <= -8.0) {
            //gameObject.SetActive(false);
        }


    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Activator") {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (gameObject.activeSelf) {
            if (other.tag == "Activator") {
                canBePressed = false; //makes them disappear
                GameManager2.instance.NoteMissed();
                //Debug.Log(transform.position.x);
                pos = new Vector3(-3.0f, transform.position.y, transform.position.z);
                Instantiate(missEffect, transform.position, missEffect.transform.rotation);
            }
        }
    }

}
