using UnityEngine;

public class RewardsButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _rewards;

    public void OnRewards()
    {
        _stateHandler.ClosePanel(_currentPanel);
        _stateHandler.OpenPanel(_rewards);
    }
}
