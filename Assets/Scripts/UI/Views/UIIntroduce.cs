using EventDef;
using UIFramework;
using UnityEngine;

/// <summary>
/// ui提示信息界面
/// </summary>
public class UIIntroduce : UIAbstractView {
    [SerializeField]
    GameObject _panel;
    protected override void Awake()
    {
        base.Awake();
        _panel.SetActive(true);
    }

    public void OnCloseButtonClick()
    {
        Events.Get<UIIntroduceCloseEvent>().Raise();
        Events.Get<UIHomeOpenEvent>().Raise();
    }
}