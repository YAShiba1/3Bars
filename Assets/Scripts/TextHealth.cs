using TMPro;
using UnityEngine;

public class TextHealth : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _textHealth;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
        OnHealthChanged(_player.CurrentHealth);
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    public void OnHealthChanged(float newHealth)
    {
        _textHealth.text = newHealth.ToString("F0") + "/" + _player.MaxHealth;
    }
}