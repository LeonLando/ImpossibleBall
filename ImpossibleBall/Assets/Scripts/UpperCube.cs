using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCube : MonoBehaviour
{
    public GameObject ActivateObj;
    //public Animator Anim;

    public void NextUpperCube()
    {
        ActivateObj.GetComponent<Animator>().SetBool("IsOn", true);
        //Anim.SetBool("IsOn", true);
    }

    //public void Go()
    //{
    //    Debug.Log("sda");
    //}
}
