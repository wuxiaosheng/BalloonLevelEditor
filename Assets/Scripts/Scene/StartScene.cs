using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : Scene
{
    public override void onEnter()
    {
        base.onEnter();
        replacePanel<StartPanel>("StartPanel");
    }
}
