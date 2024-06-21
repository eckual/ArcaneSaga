using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class IntroPanel : PanelBase
{
    [SerializeField] private Image splashIcon;
    [SerializeField] private float fadeDuration = 1.5f;
    
    public override void Initialize()
    {
    }

    protected override void ReleaseReferences()
    {
    }
    
    public override void OpenPanel(Action callBack = null)
    {
        base.OpenPanel();
        splashIcon.DOFade(0, fadeDuration).SetEase(Ease.OutBack);
    }
    
}
