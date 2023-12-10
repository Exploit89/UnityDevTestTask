using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private Image _mute;

    public void OnSound()
    {
        if (_sound.volume != 0)
        {
            _sound.volume = 0;
            _mute.enabled = true;
        }
        else
        {
            _sound.volume = 0.5f;
            _mute.enabled = false;
        }
    }
}
