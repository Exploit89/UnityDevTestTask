using UnityEngine;

public class LevelRestriction : MonoBehaviour
{
    [SerializeField] private int _restrictedLevel;

    public int GetLevel()
    {
        return _restrictedLevel;
    }
}
