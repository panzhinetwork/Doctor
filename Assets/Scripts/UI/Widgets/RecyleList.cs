using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyleList : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<GameObject> _list;

    private int _i = 0;
    private int _nCount = 0;
    private float _lLastTime = 0;
    private bool _bLoop = true;
    void Start()
    {
        _nCount = _list.Count;
        _lLastTime = Time.time;
        if (_nCount > 0)
            _list[_i].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!_bLoop)
            return;
        if (_nCount == 0)
            return;
        float currentTicks = Time.time;
        if (currentTicks - _lLastTime < 5.0f)
            return;

        _lLastTime = currentTicks;
        _list[_i].SetActive(false);
        _i++;
        if (_i == _nCount)
            _i = 0;
        _list[_i].SetActive(true);
    }

    void SetLoop(bool bLoop)
    {
        _bLoop = bLoop;
    }
}
