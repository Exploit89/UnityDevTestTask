using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private TMP_Text _ticketView;
    [SerializeField] private int _tickets;

    public void AddTickets(int count)
    {
        _tickets += count;
        _ticketView.text = _tickets.ToString();
    }
}
