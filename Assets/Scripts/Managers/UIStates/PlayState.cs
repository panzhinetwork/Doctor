using EventDef;
using UIFramework;
using UnityEngine;

public class PlayState : UIState
{
    public override void EnterState()
    {
        OnCloseUIMessage();
        OnCloseUIIntroduce();
        OnCloseUIVideo();
        OnShowUIBackground();
        OnShowUIHome();
    }

    public override void ExitState()
    {
    }

    private void Awake()
    {
        Events.Get<UIMessageOpenEvent>().AddListener(OnShowUIMessage);
        Events.Get<UIMessageCloseEvent>().AddListener(OnCloseUIMessage);

        Events.Get<UIIntroduceOpenEvent>().AddListener(OnShowUIIntroduce);
        Events.Get<UIIntroduceCloseEvent>().AddListener(OnCloseUIIntroduce);

        Events.Get<UIHomeOpenEvent>().AddListener(OnShowUIHome);
        Events.Get<UIHomeCloseEvent>().AddListener(OnCloseUIHome);

        Events.Get<UIVideoOpenEvent>().AddListener(OnShowUIVideo);
        Events.Get<UIVideoCloseEvent>().AddListener(OnCloseUIVideo);

        Events.Get<UIBackgroundOpenEvent>().AddListener(OnShowUIBackground);
        Events.Get<UIBackgroundCloseEvent>().AddListener(OnCloseUIBackground);
    }

    private void OnDestroy()
    {
        Events.Get<UIMessageOpenEvent>().RemoveListener(OnShowUIMessage);
        Events.Get<UIMessageCloseEvent>().RemoveListener(OnCloseUIMessage);

        Events.Get<UIIntroduceOpenEvent>().RemoveListener(OnShowUIIntroduce);
        Events.Get<UIIntroduceCloseEvent>().RemoveListener(OnCloseUIIntroduce);

        Events.Get<UIHomeOpenEvent>().RemoveListener(OnShowUIHome);
        Events.Get<UIHomeCloseEvent>().RemoveListener(OnCloseUIHome);

        Events.Get<UIVideoOpenEvent>().RemoveListener(OnShowUIVideo);
        Events.Get<UIVideoCloseEvent>().RemoveListener(OnCloseUIVideo);

        Events.Get<UIBackgroundOpenEvent>().RemoveListener(OnShowUIBackground);
        Events.Get<UIBackgroundCloseEvent>().RemoveListener(OnCloseUIBackground);
    }

    private void OnShowUIMessage(UIMessageData data)
    {
        Pack.ShowView<UIMessage, UIMessageData>(data);
    }

    private void OnCloseUIMessage()
    {
        Pack.HideView<UIMessage>();
    }

    private void OnShowUIIntroduce()
    {
        Pack.ShowView<UIIntroduce>();
    }

    private void OnCloseUIIntroduce()
    {
        Pack.HideView<UIIntroduce>();
    }

    private void OnShowUIHome()
    {
        Pack.ShowView<UIHome>();
    }

    private void OnCloseUIHome()
    {
        Pack.HideView<UIHome>();
    }

    private void OnShowUIVideo()
    {
        Pack.ShowView<UIVideo>();
    }

    private void OnCloseUIVideo()
    {
        Pack.HideView<UIVideo>();
    }

    private void OnShowUIBackground()
    {
        Pack.ShowView<UIBackground>();
    }

    private void OnCloseUIBackground()
    {
        Pack.HideView<UIBackground>();
    }
}