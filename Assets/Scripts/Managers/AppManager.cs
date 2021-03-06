﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UIFramework;
using System.Runtime.InteropServices;

public class AppManager : MonoBehaviour
{
    [SerializeField]
    UISettings _uiSettings = default;

    [SerializeField]
    private UIState _playState = default;

    private UIPack _uiPack;
    private UIState _currentState;

    [SerializeField]
    public string _key = "0";

#if !UNITY_EDITOR
    [DllImport("Auth64")]
    public static extern int Permission(string key);
#endif

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
 #if !UNITY_EDITOR
        if (Permission(_key) == 0)
        {
            Application.Quit();
            return;
        }
#endif
        Debug.Log("game start...");
        DontDestroyOnLoad(gameObject);

        Init();

        _uiPack = _uiSettings.CreatePackInstance();
        _playState.Init(_uiPack);
        ChangeStage(_playState);
    }
}