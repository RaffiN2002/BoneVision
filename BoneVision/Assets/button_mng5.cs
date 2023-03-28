using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_mng5 : MonoBehaviour
{
    public GameObject Ilium;
    public GameObject Ischium;
    public GameObject Pubis;

    public GameObject ilium_text;
    public GameObject ischium_text;
    public GameObject pubis_text;

    void Start(){
        ilium_text.SetActive(false);
        ischium_text.SetActive(false);
        pubis_text.SetActive(false);
    }

    public void info1(){
        if(ilium_text != null){
            bool isActive = ilium_text.activeSelf;
            ilium_text.SetActive(!isActive);
        }
    }

    public void info2(){
        if(ischium_text != null){
            bool isActive = ischium_text.activeSelf;
            ischium_text.SetActive(!isActive);
        }
    }

    public void info3(){
        if(pubis_text != null){
            bool isActive = pubis_text.activeSelf;
            pubis_text.SetActive(!isActive);
        }
    }

    public void TargetFound(){
        Ilium.SetActive(true);
        Ischium.SetActive(true);
        Pubis.SetActive(true);
    }

    public void TargetLost(){
        Ilium.SetActive(false);
        Ischium.SetActive(false);
        Pubis.SetActive(false);
    }
}
