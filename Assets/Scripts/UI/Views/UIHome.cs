using EventDef;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ui提示信息界面
/// </summary>
public class UIHome : UIAbstractView {

    protected override void Awake()
    {
        base.Awake();
        //_view.SetActive(false);
    }

    public void OnButton1Clicked()
    {
        Events.Get<UIIntroduceOpenEvent>().Raise();
        Events.Get<UIHomeCloseEvent>().Raise();
        Events.Get<UIVideoCloseEvent>().Raise();
    }

    public void OnButton2Clicked()
    {
        Events.Get<UIIntroduceCloseEvent>().Raise();
        Events.Get<UIHomeCloseEvent>().Raise();
        Events.Get<UIVideoOpenEvent>().Raise();
    }
}