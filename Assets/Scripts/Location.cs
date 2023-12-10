using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    [SerializeField] private List<GameObject> _levels;

    public List<GameObject> GetLevels()
    {
        List<GameObject> newList = new List<GameObject>();
        newList = _levels;
        return newList;
    }
}
