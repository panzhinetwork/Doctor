using EventDef;
using UIFramework;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// ui提示信息界面
/// </summary>
public class ScaleObj : MonoBehaviour {

    public void OnEnable()
    {
        transform.localScale = Vector3.zero;
        transform.DOScale(Vector3.one, 0.4f);
    }
}