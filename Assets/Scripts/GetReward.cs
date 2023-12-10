using UnityEngine;
using TMPro;

public class GetReward : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void SetDay(int day)
    {
        _text.text = "Day " + day.ToString();
    }
}
