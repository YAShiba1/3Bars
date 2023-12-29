using UnityEngine;
using UnityEngine.UI;

public class UnevenHealthBar : HealthBar
{
    protected override void OnHealthChanged(float newHealth)
    {
        _slider.value = newHealth;
    }
}
