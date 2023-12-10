using UnityEngine;

public class DayCounter : MonoBehaviour
{
    [SerializeField] private int _currentDay;

    public int GetCurrentDay()
    {
        return _currentDay;
    }
}
