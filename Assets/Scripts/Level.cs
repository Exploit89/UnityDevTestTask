using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private int _currentLevel;
    [SerializeField] private int _reward;
    [SerializeField] private Wallet _playerWallet;
    [SerializeField] private Image _lock;

    private int _childIndex = 1;

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public void Unlock()
    {
        gameObject.GetComponent<Button>().interactable = true;
        if (_lock != null)
            _lock.enabled = false;
    }

    public void GetReward()
    {
        _playerWallet.AddTickets(_reward);
        GetComponent<Button>().interactable = false;
        GetComponentsInChildren<TMP_Text>()[0].text = "";
        GetComponentsInChildren<Image>()[_childIndex].enabled = true;

    }
}
