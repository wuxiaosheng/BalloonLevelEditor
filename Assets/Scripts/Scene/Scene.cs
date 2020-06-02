using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene
{
    protected Panel _panel;
    public virtual void onEnter() { 
    
    }

    public virtual void update() { 
    
    }

    public virtual void onExit() {
        if (_panel != null)
        {
            _panel.gameObject.SetActive(false);
            _panel.onExit();
            Component.Destroy(_panel);
        }
    }

    public void replacePanel<T>(string name) where T : Panel {
        if (_panel != null) {
            _panel.gameObject.SetActive(false);
            _panel.onExit();
            Component.Destroy(_panel);
        }
        GameObject canvas = GameObject.Find("Canvas");
        Transform child = canvas.transform.Find(name);
        if (child == null) { return; }
        child.gameObject.SetActive(true);
        _panel = child.gameObject.AddComponent<T>();
        _panel.onEnter();
    }
}
