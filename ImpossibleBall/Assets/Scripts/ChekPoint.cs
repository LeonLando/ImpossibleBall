using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    [SerializeField] private GameObject _partycle;
    [SerializeField] private GameObject _obj;

    public void Activated()
    {
        _partycle.SetActive(true);
        Destroy(_obj);
    }

}
