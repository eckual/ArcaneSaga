using System.Collections;
using System.Collections.Generic;
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
    
    public override void OpenPanel()
    {
        splashIcon.DOFade(0, fadeDuration).SetEase(Ease.OutBack);
        base.OpenPanel();
    }
    
}
