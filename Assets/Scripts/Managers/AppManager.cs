using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UIFramework;

public class AppManager : MonoBehaviour
{
    [SerializeField]
    UISettings _uiSettings = default;

    [SerializeField]
    private UIState _playState = default;

    private UIPack _uiPack;
    private UIState _currentState;

    private void ChangeStage(UIState stage)
    {
        if (_currentState != stage)
        {
            if (_currentState != null)
            {
                _currentState.ExitState();
            }
            _currentState = stage;
            _currentState.EnterState();
        }
    }

    private void Init()
    {
        AppData.instance.Init();
    }

    private void Awake()
    {
        Debug.Log("game start...");
        DontDestroyOnLoad(gameObject);

        Init();

        _uiPack = _uiSettings.CreatePackInstance();
        _playState.Init(_uiPack);
        ChangeStage(_playState);
    }
}