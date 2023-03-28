using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_mng4 : MonoBehaviour
{
    public GameObject Femur;
    public GameObject Patella;
    public GameObject Tibia;
    public GameObject Fibula;
    public GameObject Tarsal;
    public GameObject Metatarsal;

    public GameObject femur_text;
    public GameObject patella_text;
    public GameObject tibia_text;
    public GameObject fibula_text;
    public GameObject tarsal_text;
    public GameObject metatarsal_text;

    void Start(){
        femur_text.SetActive(false);
        patella_text.SetActive(false);
        tibia_text.SetActive(false);
        fibula_text.SetActive(false);
        tarsal_text.SetActive(false);
        metatarsal_text.SetActive(false);
    }

    public void info1(){
        if(femur_text != null){
            bool isActive = femur_text.activeSelf;
            femur_text.SetActive(!isActive);
        }
    }

    public void info2(){
        if(patella_text != null){
            bool isActive = patella_text.activeSelf;
            patella_text.SetActive(!isActive);
        }
    }

    public void info3(){
        if(tibia_text != null){
            bool isActive = tibia_text.activeSelf;
            tibia_text.SetActive(!isActive);
        }
    }

    public void info4(){
        if(fibula_text != null){
            bool isActive = fibula_text.activeSelf;
            fibula_text.SetActive(!isActive);
        }
    }

    public void info5(){
        if(tarsal_text != null){
            bool isActive = tarsal_text.activeSelf;
            tarsal_text.SetActive(!isActive);
        }
    }

    public void info6(){
        if(metatarsal_text != null){
            bool isActive = metatarsal_text.activeSelf;
            metatarsal_text.SetActive(!isActive);
        }
    }

    public void TargetFound(){
        Femur.SetActive(true);
        Patella.SetActive(true);
        Tibia.SetActive(true);
        Fibula.SetActive(true);
        Tarsal.SetActive(true);
        Metatarsal.SetActive(true);
    }

    public void TargetLost(){
        Femur.SetActive(false);
        Patella.SetActive(false);
        Tibia.SetActive(false);
        Fibula.SetActive(false);
        Tarsal.SetActive(false);
        Metatarsal.SetActive(false);
    }

    public void back(){
        SceneManager.LoadScene("ARMenu");
    }
}
