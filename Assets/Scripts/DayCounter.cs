using UnityEngine;

public class DayCounter : MonoBehaviour
{
    [SerializeField] private int _currentDay;

    public int GetCurrentDay()
    {
        // for example
        return _currentDay;
    }
}
