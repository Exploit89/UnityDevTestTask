using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private int _currentLevel;
    [SerializeField] private int _reward;
    [SerializeField] private Wallet _playerWallet;

    private int _childIndex = 1;

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public void Unlock()
    {
        gameObject.GetComponent<Button>().interactable = true;
        gameObject.GetComponentsInChildren<Image>()[_childIndex].enabled = false;
    }

    public void GetReward()
    {
        _playerWallet.AddTickets(_reward);
        GetComponent<Button>().interactable = false;
    }
}
