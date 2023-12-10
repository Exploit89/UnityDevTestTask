using UnityEngine;
using TMPro;

public class GetReward : MonoBehaviour
{
    [SerializeField] private TMP_Text _textDay;
    [SerializeField] private TMP_Text _textRewardAmount;

    public void SetRewards(int day, int reward)
    {
        _textDay.text = "Day " + day.ToString();
        _textRewardAmount.text = "x" + reward.ToString();
    }
}
