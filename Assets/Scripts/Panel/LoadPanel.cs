using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPanel : Panel
{
    public override void onEnter()
    {
        base.onEnter();
        _children["BtnClose"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Scene scene = SceneManager.getInstance().getScene();
            scene.replacePanel<StartPanel>("StartPanel");
        });
    }
}
