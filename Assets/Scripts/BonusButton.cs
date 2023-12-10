using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _getRewards;
    [SerializeField] private DayCounter _dayCounter;
    [SerializeField] private Image _imageDone;
    [SerializeField] private Wallet _playerWallet;
    [SerializeField] private int _currentDayBonus;
    [SerializeField] private int _rewardAmount;

    public void OnBonus()
    {
        if (_dayCounter.GetCurrentDay() >= _currentDayBonus)
        {
            _imageDone.enabled = true;
            _stateHandler.OpenPanel(_getRewards);
            _getRewards.GetComponent<GetReward>().SetDay(_currentDayBonus);
            GetComponent<Button>().interactable = false;
            _playerWallet.AddTickets(_rewardAmount);
        }
    }
}
