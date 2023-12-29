using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private Coroutine _changeValueOfBarJob;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.minValue = _player.MinHealth;
        _slider.value = _player.CurrentHealth;
    }

    public void ChangeBarValue()
    {
        if (_changeValueOfBarJob != null)
        {
            StopCoroutine(_changeValueOfBarJob);
        }

        _changeValueOfBarJob = StartCoroutine(ChangeSliderValue(_player.CurrentHealth));
    }

    private IEnumerator ChangeSliderValue(float targetValue)
    {
        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _speed * Time.deltaTime);

            yield return null;
        }
    }
}