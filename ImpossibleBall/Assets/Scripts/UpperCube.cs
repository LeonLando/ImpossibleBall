using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCube : MonoBehaviour
{
    [SerializeField] private GameObject _activateObj;

    public void NextUpperCube()
    {
        _activateObj.GetComponent<Animator>().SetBool("IsOn", true);
    }

}
