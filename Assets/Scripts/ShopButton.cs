using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _currentPanel;

    public void OnShop()
    {
        _stateHandler.ClosePanel(_currentPanel);
        _stateHandler.OpenPanel(_shop);
    }
}
