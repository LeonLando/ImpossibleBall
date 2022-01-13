using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroysPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _obj;
    [SerializeField] private float _time;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Timer());
        }
    }


    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(_time);
        Destroy(_obj);
    }
}
