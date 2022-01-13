using UnityEngine;

public class OnOffObject : MonoBehaviour
{
    [SerializeField] private string _selectTag;
    [SerializeField] private GameObject _obj;
    [SerializeField] private bool _onObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_selectTag))
        {
            if (_onObj)
            {
                _obj.SetActive(true);
            }
            if (_onObj == false)
            {
                _obj.SetActive(false);
            }
        }
    }
}
