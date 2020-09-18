using System.Collections;
using System.Collections.Generic;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;
using EventDef;

public class ShowObj : MonoBehaviour
{
    [SerializeField] GameObject _obj1;
    [SerializeField] GameObject _obj2;

    public void OnButtonClicked()
    {
        if (_obj1 != null)
            _obj1.SetActive(false);
        if (_obj2 != null)
            _obj2.SetActive(true);
    }
}
