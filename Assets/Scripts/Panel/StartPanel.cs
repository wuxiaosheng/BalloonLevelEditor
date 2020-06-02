using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : Panel
{
    public override void onEnter()
    {
        base.onEnter();
        _children["BtnNew"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            SceneManager.getInstance().replaceScene<EditScene>();
        });

        _children["BtnLoad"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Scene scene = SceneManager.getInstance().getScene();
            scene.replacePanel<LoadPanel>("LoadPanel");
        });

        _children["BtnExit"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            Application.Quit();
        });
    }

    
}
