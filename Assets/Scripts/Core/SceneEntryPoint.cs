using System.Collections.Generic;
using Controllers;
using Core;
using UnityEngine;

public class SceneEntryPoint : BaseMonoBehaviour
{
    [SerializeField] private List<ControllerBase> controllers;
    [SerializeField] private List<PanelBase> panels;
    
    private void Awake()
    {
        for (var i = 0; i < controllers.Count; i++)
            controllers[i].Initialize();

        for (var j = 0; j < panels.Count; j++)
        {
            panels[j].Initialize();
            if (panels[j].IsPermenant) {panels[j].OpenPanel();}
            else panels[j].ClosePanel();
        }
    }

    protected override void ReleaseReferences()
    {
        controllers = null;
        panels = null;
    }
    
}
