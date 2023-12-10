using UnityEngine;

public class IAPReward : MonoBehaviour
{
    [SerializeField] private Wallet _playerWallet;
    [SerializeField] private int _rewardAmount;

    public void GetReward()
    {
        _playerWallet.AddTickets(_rewardAmount);
    }
}
