using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _getRewards;
    [SerializeField] private DayCounter _dayCounter;
    [SerializeField] private Image _imageDone;

    private int _currentDayBonus = 1;

    public void OnBonus()
    {
        if (_dayCounter.GetCurrentDay() == _currentDayBonus)
        {
            _imageDone.enabled = true;
            _stateHandler.OpenPanel(_getRewards);
            _getRewards.GetComponent<GetReward>().SetDay(_currentDayBonus);
            GetComponent<Button>().interactable = false;
        }
    }
}
