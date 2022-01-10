using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    [SerializeField] private GameObject Partycle;
    [SerializeField] private GameObject Obj;

    public void Activated()
    {
        Partycle.SetActive(true);
        Destroy(Obj);
    }

}
