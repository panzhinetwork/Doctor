using EventDef;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

/// <summary>
/// ui提示信息界面
/// </summary>
public class UIVideo : UIAbstractView {

    [SerializeField]
    VideoPlayer _video;

    private float _vol = 1.0f;
    private bool _mute = true;

    protected override void Awake()
    {
        base.Awake();
        _video.url = Application.streamingAssetsPath + "/1.mp4";
    }

    public void OnPlayClicked()
    {
        _video.Play();
    }

    public void OnPauseClicked()
    {
        _video.Pause();
    }

    public void OnCloseClicked()
    {
        _video.Stop();
        Events.Get<UIHomeOpenEvent>().Raise();
        Events.Get<UIVideoCloseEvent>().Raise();
    }

    public void OnVMuteClicked()
    {
        _video.SetDirectAudioMute(0, _mute);
        _mute = !_mute;
    }

    public void OnVUClicked()
    {
        _vol += 0.1f;
        if (_vol > 1.0f)
            _vol = 1.0f;
        _video.SetDirectAudioVolume(0, _vol);
    }

    public void OnVDClicked()
    {
        _vol -= 0.1f;
        if (_vol < 0.0f)
            _vol = 0.0f;
        _video.SetDirectAudioVolume(0, _vol);
    }
}