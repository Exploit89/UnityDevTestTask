using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    [SerializeField] private Image _mute;

    public void OnMusic()
    {
        if (_music.isPlaying && _music.volume != 0)
        {
            _music.volume = 0;
            _mute.enabled = true;
        }
        else
        {
            _music.volume = 0.25f;
            _mute.enabled = false;
        }
    }
}
