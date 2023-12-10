using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private StateHandler _stateHandler;
    [SerializeField] private GameObject _levels;
    [SerializeField] private GameObject _currentPanel;

    public void OnPlay()
    {
        _stateHandler.ClosePanel(_currentPanel);
        _stateHandler.OpenPanel(_levels);
    }
}
