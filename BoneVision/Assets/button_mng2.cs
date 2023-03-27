using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_mng2 : MonoBehaviour
{
    public GameObject TrueRibs;
    public GameObject FalseRibs;
    public GameObject FloatingRibs;
    public GameObject Sternum;
    public GameObject Scapula;

    public GameObject truerib_text;
    public GameObject falserib_text;
    public GameObject floatingrib_text;
    public GameObject sternum_text;
    public GameObject scapula_text;

    void start(){
        truerib_text.SetActive(false);
        falserib_text.SetActive(false);
        floatingrib_text.SetActive(false);
        sternum_text.SetActive(false);
        scapula_text.SetActive(false);
    }

    public void info1(){
        if(truerib_text != null){
            bool isActive = truerib_text.activeSelf;
            truerib_text.SetActive(isActive);
        }
    }

    public void info2(){
        if(falserib_text != null){
            bool isActive = falserib_text.activeSelf;
            falserib_text.SetActive(isActive);
        }
    }

    public void info3(){
        if(floatingrib_text != null){
            bool isActive = floatingrib_text.activeSelf;
            floatingrib_text.SetActive(isActive);
        }
    }

    public void info4(){
        if(sternum_text != null){
            bool isActive = sternum_text.activeSelf;
            sternum_text.SetActive(isActive);
        }
    }

    public void info5(){
        if(scapula_text != null){
            bool isActive = scapula_text.activeSelf;
            scapula_text.SetActive(isActive);
        }
    }


    public void TargetFound(){
        TrueRibs.SetActive(true);
        FalseRibs.SetActive(true);
        FloatingRibs.SetActive(true);
        Sternum.SetActive(true);
        Scapula.SetActive(true);
    }

    public void TargetLost(){
        TrueRibs.SetActive(false);
        FalseRibs.SetActive(false);
        FloatingRibs.SetActive(false);
        Sternum.SetActive(false);
        Scapula.SetActive(false);
    }
}
