using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditPanel : Panel
{
    public override void onEnter()
    {
        base.onEnter();
        _children["BtnExit"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            SceneManager.getInstance().replaceScene<StartScene>();
        });

        _children["BtnSave"].GetComponent<Button>().onClick.AddListener(delegate ()
        {
            
        });
    }
}
