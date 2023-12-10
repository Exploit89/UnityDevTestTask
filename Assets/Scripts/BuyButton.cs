using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private LevelRestriction _restrictionlevel;
    [SerializeField] private Level _level;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private int _price;
    [SerializeField] private Location _location;

    public void TryBuy()
    {
        if (ValidateLevel())
        {
            if (_wallet.TryBuy(_price))
            {
                _wallet.SpendTickets(_price);
                _button.interactable = false;
                UnlockLocation();
            }
        }
    }

    private bool ValidateLevel()
    {
        return _restrictionlevel.GetLevel() <= _level.GetCurrentLevel();
    }

    private void UnlockLocation()
    {
        if (_location != null)
        {
            foreach (var item in _location.GetLevels())
            {
                item.GetComponent<Level>().Unlock();
            }
        }
    }
}
