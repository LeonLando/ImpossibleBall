using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off_Object : MonoBehaviour
{
    [SerializeField] private string SelectTag;
    public GameObject Obj;
    [SerializeField] private bool OnObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(SelectTag))
        {
            if (OnObj)
            {
                Obj.SetActive(true);
            }
            if (OnObj == false)
            {
                Obj.SetActive(false);
            }
        }
    }
}
