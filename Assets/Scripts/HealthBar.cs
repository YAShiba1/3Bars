using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] protected Slider _slider;
    [SerializeField] protected Player _player;

    private void OnEnable()
    {
        SubscribeToHealthEvent();
    }

    private void OnDisable()
    {
        UnsubscribeFromHealthEvent();
    }

    protected virtual void SubscribeToHealthEvent() 
    {
        _player.HealthChanged += OnHealthChanged;
    }

    protected virtual void UnsubscribeFromHealthEvent() 
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    protected virtual void OnHealthChanged(float newHealth) { }
}