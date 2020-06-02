using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    protected Dictionary<string, Transform> _children = new Dictionary<string, Transform>();
    public virtual void onEnter() {
        loopAllChildren(transform);
    }

    public virtual void update() { 
    
    }

    public virtual void onExit() { 
    
    }

    private void loopAllChildren(Transform obj)
    {
        for (int i = 0; i < obj.childCount; i++)
        {
            Transform child = obj.GetChild(i);
            loopAllChildren(child);
            if (!_children.ContainsKey(child.name))
            {
                _children.Add(child.name, child);
            }
        }
    }
}
