using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hyperlinkAR : MonoBehaviour
{
    public void toSkull(){
        SceneManager.LoadScene("AR_skull");
    }

    public void toRibs(){
        SceneManager.LoadScene("AR_ribs");
    }

    public void toArms(){
        SceneManager.LoadScene("AR_hands");
    }

    public void toLegs(){
        SceneManager.LoadScene("AR_legs");
    }

    public void toPelvis(){
        SceneManager.LoadScene("AR_pelvis");
    }

    public void toSpine(){
        SceneManager.LoadScene("AR_spine");
    }

    public void back(){
        SceneManager.LoadScene("SampleScene");
    }
}
