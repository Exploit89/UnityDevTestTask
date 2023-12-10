using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _settings;

    public void OnSettings()
    {
        _stateHandler.ClosePanel(_currentPanel);
        _stateHandler.OpenPanel(_settings);
    }
}
