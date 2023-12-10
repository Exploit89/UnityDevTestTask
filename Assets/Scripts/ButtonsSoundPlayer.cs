using UnityEngine;

public class ButtonsSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void OnPlay()
    {
        _audioSource.Play();
    }
}
