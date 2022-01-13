using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutOutScript : MonoBehaviour
{
    [SerializeField] private GameObject _activateObj;
    private Animator _anim;
    private Animator _activateObjAnim;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _activateObjAnim = _activateObj.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _anim.SetBool("IsOn", true);
            _activateObjAnim.SetBool("IsOn", true);
        }
    }
}
