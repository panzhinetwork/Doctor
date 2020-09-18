using System.Collections;
using System.Collections.Generic;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;
using EventDef;

public class HidePicture : MonoBehaviour
{
    [SerializeField] Image _image;

    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    public void OnButtonClicked()
    {
        _image.gameObject.SetActive(false);
    }
}
