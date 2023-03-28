using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_mng6 : MonoBehaviour
{
    public GameObject CervicalSpine;
    public GameObject ThoracicSpine;
    public GameObject LumbarSpine;
    public GameObject Sacrum;
    public GameObject Coccyx;

    public GameObject cervical_text;
    public GameObject thoracic_text;
    public GameObject lumbar_text;
    public GameObject sacrum_text;
    public GameObject coccyx_text;

    void Start(){
        cervical_text.SetActive(false);
        thoracic_text.SetActive(false);
        lumbar_text.SetActive(false);
        sacrum_text.SetActive(false);
        coccyx_text.SetActive(false);
    }

    public void info1(){
        if(cervical_text != null){
            bool isActive = cervical_text.activeSelf;
            cervical_text.SetActive(!isActive);
        }
    }

    public void info2(){
        if(thoracic_text != null){
            bool isActive = thoracic_text.activeSelf;
            thoracic_text.SetActive(!isActive);
        }
    }

    public void info3(){
        if(lumbar_text != null){
            bool isActive = lumbar_text.activeSelf;
            lumbar_text.SetActive(!isActive);
        }
    }

    public void info4(){
        if(sacrum_text != null){
            bool isActive = sacrum_text.activeSelf;
            sacrum_text.SetActive(!isActive);
        }
    }

    public void info5(){
        if(coccyx_text != null){
            bool isActive = coccyx_text.activeSelf;
            coccyx_text.SetActive(!isActive);
        }
    }


    public void TargetFound(){
        CervicalSpine.SetActive(true);
        ThoracicSpine.SetActive(true);
        LumbarSpine.SetActive(true);
        Sacrum.SetActive(true);
        Coccyx.SetActive(true);
    }

    public void TargetLost(){
        CervicalSpine.SetActive(false);
        ThoracicSpine.SetActive(false);
        LumbarSpine.SetActive(false);
        Sacrum.SetActive(false);
        Coccyx.SetActive(false);
    }
}
