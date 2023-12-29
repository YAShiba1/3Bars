using TMPro;
using UnityEngine;

public class TextHealth : HealthBar
{
    [SerializeField] private TMP_Text _textHealth;

    protected override void SubscribeToHealthEvent() 
    {
        base.SubscribeToHealthEvent();
        OnHealthChanged(_player.CurrentHealth);
    }

    protected override void OnHealthChanged(float newHealth)
    {
        _textHealth.text = newHealth.ToString("F0") + "/" + _player.MaxHealth;
    }
}