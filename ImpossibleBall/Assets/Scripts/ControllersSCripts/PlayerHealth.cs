using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ImpossibleBall.Inputs;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Text _healthText;
    private float _health = 3;
    private PlayerContoller _playerContr;
    private void Awake()
    {
        _playerContr = GetComponent<PlayerContoller>();
    }
    public void TakeDamage()
    {
        if (_health > 0)
        {
            _health -= 1;
            _healthText.text = _health.ToString();
            _playerContr.GoToChekPoint();
        }
        if (_health <= 0)
        {
            _playerContr.ResetLevel();
        }

    }




}
