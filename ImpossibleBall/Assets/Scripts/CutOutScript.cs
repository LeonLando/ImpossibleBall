using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutOutScript : MonoBehaviour
{
    private Animator Anim;
    [SerializeField] GameObject ActivateObj;
    private Animator ActivateObjAnim;
    private void Awake()
    {
        Anim = GetComponent<Animator>();
        ActivateObjAnim = ActivateObj.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Anim.SetBool("IsOn", true);
            ActivateObjAnim.SetBool("IsOn", true);
        }
    }
}
