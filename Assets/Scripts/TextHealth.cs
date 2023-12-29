using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextHealth : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _textHealth;

    private void Update()
    {
        Display();
    }

    private void Display()
    {
        _textHealth.text = FormatText();
    }

    private string FormatText()
    {
        return _player.CurrentHealth.ToString("F0") + "/" + _player.MaxHealth;
    }
}