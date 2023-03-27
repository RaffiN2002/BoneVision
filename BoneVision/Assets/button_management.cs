using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_management : MonoBehaviour
{
    public GameObject Frontal;
    public GameObject Parietal;
    public GameObject Temporal;
    public GameObject Ocipital;
    public GameObject Sphenoid;
    public GameObject Zygomatic;

    public GameObject frontal_text;
    public GameObject parietal_text;
    public GameObject temporal_text;
    public GameObject ocipital_text;
    public GameObject sphenoid_text;
    public GameObject zygomatic_text;

    void start(){
        frontal_text.SetActive(false);
        parietal_text.SetActive(false);
        temporal_text.SetActive(false);
        ocipital_text.SetActive(false);
        sphenoid_text.SetActive(false);
        zygomatic_text.SetActive(false);
    }

    public void info1(){
        if(frontal_text != null){
            bool isActive = frontal_text.activeSelf;
            frontal_text.SetActive(isActive);
        }
    }

    public void info2(){
        if(parietal_text != null){
            bool isActive = parietal_text.activeSelf;
            parietal_text.SetActive(isActive);
        }
    }

    public void info3(){
        if(temporal_text != null){
            bool isActive = temporal_text.activeSelf;
            temporal_text.SetActive(isActive);
        }
    }

    public void info4(){
        if(ocipital_text != null){
            bool isActive = ocipital_text.activeSelf;
            ocipital_text.SetActive(isActive);
        }
    }

    public void info5(){
        if(sphenoid_text != null){
            bool isActive = sphenoid_text.activeSelf;
            sphenoid_text.SetActive(isActive);
        }
    }

    public void info6(){
        if(zygomatic_text != null){
            bool isActive = zygomatic_text.activeSelf;
            zygomatic_text.SetActive(isActive);
        }
    }

    public void TargetFound(){
        Frontal.SetActive(true);
        Parietal.SetActive(true);
        Temporal.SetActive(true);
        Ocipital.SetActive(true);
        Sphenoid.SetActive(true);
        Zygomatic.SetActive(true);
    }

    public void TargetLost(){
        Frontal.SetActive(false);
        Parietal.SetActive(false);
        Temporal.SetActive(false);
        Ocipital.SetActive(false);
        Sphenoid.SetActive(false);
        Zygomatic.SetActive(false);
    }
}
