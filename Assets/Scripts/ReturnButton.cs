using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _menu;

    public void OnReturn()
    {
        _stateHandler.ClosePanel(_currentPanel);
        _stateHandler.OpenPanel(_menu);
    }
}
