using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_mng3 : MonoBehaviour
{
    public GameObject Carpal;
    public GameObject Metacarpals;
    public GameObject Phalanges;
    public GameObject Radius;
    public GameObject Ulna;

    public GameObject carpal_text;
    public GameObject metacarpal_text;
    public GameObject phalanges_text;
    public GameObject radius_text;
    public GameObject ulna_text;

    void Start(){
        carpal_text.SetActive(false);
        metacarpal_text.SetActive(false);
        phalanges_text.SetActive(false);
        radius_text.SetActive(false);
        ulna_text.SetActive(false);
    }

    public void info1(){
        if(carpal_text != null){
            bool isActive = carpal_text.activeSelf;
            carpal_text.SetActive(!isActive);
        }
    }

    public void info2(){
        if(metacarpal_text != null){
            bool isActive = metacarpal_text.activeSelf;
            metacarpal_text.SetActive(!isActive);
        }
    }

    public void info3(){
        if(phalanges_text != null){
            bool isActive = phalanges_text.activeSelf;
            phalanges_text.SetActive(!isActive);
        }
    }

    public void info4(){
        if(radius_text != null){
            bool isActive = radius_text.activeSelf;
            radius_text.SetActive(!isActive);
        }
    }

    public void info5(){
        if(ulna_text != null){
            bool isActive = ulna_text.activeSelf;
            ulna_text.SetActive(!isActive);
        }
    }


    public void TargetFound(){
        Carpal.SetActive(true);
        Metacarpals.SetActive(true);
        Phalanges.SetActive(true);
        Radius.SetActive(true);
        Ulna.SetActive(true);
    }

    public void TargetLost(){
        Carpal.SetActive(false);
        Metacarpals.SetActive(false);
        Phalanges.SetActive(false);
        Radius.SetActive(false);
        Ulna.SetActive(false);
    }

    public void back(){
        SceneManager.LoadScene("ARMenu");
    }
}
