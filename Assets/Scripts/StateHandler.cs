using UnityEngine;

public class StateHandler : MonoBehaviour
{
    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    
    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}
