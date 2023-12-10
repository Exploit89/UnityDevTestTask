using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DaySlider : MonoBehaviour
{
    [SerializeField] private DayCounter _dayCounter;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Slider _slider;

    private void Update()
    {
        _slider.value = _dayCounter.GetCurrentDay();
        _text.text = _slider.value.ToString() + "/7";
    }
}
