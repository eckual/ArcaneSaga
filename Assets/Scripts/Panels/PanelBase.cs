using System;
using Core;
using UnityEngine;

public abstract class PanelBase : BaseMonoBehaviour
{
    public bool IsPermenant;
    private RectTransform _rt;
    
    public RectTransform RectTransform
    {
        get
        {
            if (_rt == null) _rt = GetComponent<RectTransform>();
            return _rt;
        }
    }
    
    protected override void ReleaseReferences()
    {
        _rt = null;
    }

    public abstract void Initialize();
    
    public virtual void OpenPanel(Action callBack = null) => gameObject.SetActive(true);
    public virtual void ClosePanel() => gameObject.SetActive(false);
    
}
